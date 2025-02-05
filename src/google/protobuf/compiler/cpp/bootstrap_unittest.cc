// Protocol Buffers - Google's data interchange format
// Copyright 2008 Google Inc.  All rights reserved.
//
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file or at
// https://developers.google.com/open-source/licenses/bsd

// Author: kenton@google.com (Kenton Varda)
//  Based on original Protocol Buffers design by
//  Sanjay Ghemawat, Jeff Dean, and others.
//
// This test insures that google/protobuf/descriptor.pb.{h,cc} match exactly
// what would be generated by the protocol compiler.  These files are not
// generated automatically at build time because they are compiled into the
// protocol compiler itself.  So, if they were auto-generated, you'd have a
// chicken-and-egg problem.
//
// If this test fails, run the script
// "generate_descriptor_proto.sh" and add
// descriptor.pb.{h,cc} to your changelist.

#include <memory>
#include <string>

#include "google/protobuf/testing/file.h"
#include "google/protobuf/testing/file.h"
#include "google/protobuf/compiler/cpp/generator.h"
#include "google/protobuf/testing/googletest.h"
#include <gtest/gtest.h>
#include "absl/container/flat_hash_map.h"
#include "absl/log/absl_check.h"
#include "absl/strings/substitute.h"
#include "google/protobuf/compiler/cpp/helpers.h"
#include "google/protobuf/compiler/importer.h"
#include "google/protobuf/descriptor.h"
#include "google/protobuf/io/zero_copy_stream_impl.h"
#include "google/protobuf/test_util2.h"

namespace google {
namespace protobuf {
namespace compiler {
namespace cpp {
namespace {
std::string FindWithDefault(
    const absl::flat_hash_map<absl::string_view, std::string>& m,
    const std::string& k, const std::string& v) {
  auto it = m.find(k);
  if (it == m.end()) return v;
  return it->second;
}

class MockErrorCollector : public MultiFileErrorCollector {
 public:
  MockErrorCollector() {}
  ~MockErrorCollector() override {}

  std::string text_;

  // implements ErrorCollector ---------------------------------------
  void RecordError(absl::string_view filename, int line, int column,
                   absl::string_view message) override {
    absl::SubstituteAndAppend(&text_, "$0:$1:$2: $3\n", filename, line, column,
                              message);
  }
};

class MockGeneratorContext : public GeneratorContext {
 public:
  void ExpectFileMatches(const std::string& virtual_filename,
                         const std::string& physical_filename) {
    auto it = files_.find(virtual_filename);
    ASSERT_TRUE(it != files_.end())
        << "Generator failed to generate file: " << virtual_filename;

    std::string expected_contents = *it->second;
    std::string actual_contents;
    ABSL_CHECK_OK(File::GetContents(
        absl::StrCat(TestUtil::TestSourceDir(), "/", physical_filename),
        &actual_contents, true))
        << physical_filename;

#ifdef WRITE_FILES  // Define to debug mismatched files.
    ABSL_CHECK_OK(File::SetContents("/tmp/expected.cc", expected_contents,
                                    true));
    ABSL_CHECK_OK(
        File::SetContents("/tmp/actual.cc", actual_contents, true));
#endif

    ASSERT_EQ(expected_contents, actual_contents)
        << physical_filename
        << " needs to be regenerated.  Please run "
           "generate_descriptor_proto.sh. "
           "Then add this file to your CL.";
  }

  // implements GeneratorContext --------------------------------------

  io::ZeroCopyOutputStream* Open(const std::string& filename) override {
    auto& map_slot = files_[filename];
    map_slot.reset(new std::string);
    return new io::StringOutputStream(map_slot.get());
  }

 private:
  absl::flat_hash_map<std::string, std::unique_ptr<std::string>> files_;
};

const char kDescriptorParameter[] = "dllexport_decl=PROTOBUF_EXPORT";
const char kCppFeaturesParameter[] = "dllexport_decl=PROTOBUF_EXPORT";
const char kPluginParameter[] = "dllexport_decl=PROTOC_EXPORT";


const char* test_protos[][2] = {
    {"google/protobuf/descriptor", kDescriptorParameter},
    {"google/protobuf/cpp_features", kCppFeaturesParameter},
    {"google/protobuf/compiler/plugin", kPluginParameter},
};

TEST(BootstrapTest, GeneratedFilesMatch) {
  // We need a mapping from the actual file to virtual and actual path
  // of the data to compare to.
  absl::flat_hash_map<absl::string_view, std::string> vpath_map;
  absl::flat_hash_map<absl::string_view, std::string> rpath_map;

  DiskSourceTree source_tree;
  source_tree.MapPath("", TestUtil::TestSourceDir());

  for (auto file_parameter : test_protos) {
    MockErrorCollector error_collector;
    Importer importer(&source_tree, &error_collector);
    const FileDescriptor* file =
        importer.Import(file_parameter[0] + std::string(".proto"));
    ASSERT_TRUE(file != nullptr)
        << "Can't import file " << file_parameter[0] + std::string(".proto")
        << "\n";
    EXPECT_EQ("", error_collector.text_);
    CppGenerator generator;
    MockGeneratorContext context;
#ifdef GOOGLE_PROTOBUF_RUNTIME_INCLUDE_BASE
    generator.set_opensource_runtime(true);
    generator.set_runtime_include_base(GOOGLE_PROTOBUF_RUNTIME_INCLUDE_BASE);
#endif
    std::string error;
    ASSERT_TRUE(generator.Generate(file, file_parameter[1], &context, &error));

    std::string vpath =
        FindWithDefault(vpath_map, file_parameter[0], file_parameter[0]);
    std::string rpath =
        FindWithDefault(rpath_map, file_parameter[0], file_parameter[0]);
    context.ExpectFileMatches(absl::StrCat(vpath, ".pb.cc"),
                              absl::StrCat(rpath, ".pb.cc"));
    context.ExpectFileMatches(absl::StrCat(vpath, ".pb.h"),
                              absl::StrCat(rpath, ".pb.h"));
  }
}

// test Generate in cpp_generator.cc
TEST(BootstrapTest, OptionNotExist) {
  cpp::CppGenerator generator;
  DescriptorPool pool;
  GeneratorContext* generator_context = nullptr;
  std::string parameter = "aaa";
  std::string error;
  ASSERT_FALSE(generator.Generate(
      pool.FindFileByName("google/protobuf/descriptor.proto"), parameter,
      generator_context, &error));
  EXPECT_EQ(error, absl::StrCat("Unknown generator option: ", parameter));
}

}  // namespace

}  // namespace cpp
}  // namespace compiler
}  // namespace protobuf
}  // namespace google
