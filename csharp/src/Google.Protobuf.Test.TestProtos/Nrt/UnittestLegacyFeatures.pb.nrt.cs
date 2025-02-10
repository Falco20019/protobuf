// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/protobuf/unittest_legacy_features.proto
// </auto-generated>
#nullable enable annotations
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace LegacyFeaturesUnittest {

  /// <summary>Holder for reflection information generated from google/protobuf/unittest_legacy_features.proto</summary>
  public static partial class UnittestLegacyFeaturesReflection {

    #region Descriptor
    /// <summary>File descriptor for google/protobuf/unittest_legacy_features.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnittestLegacyFeaturesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvcHJvdG9idWYvdW5pdHRlc3RfbGVnYWN5X2ZlYXR1cmVzLnBy",
            "b3RvEhhsZWdhY3lfZmVhdHVyZXNfdW5pdHRlc3QigwEKE1Rlc3RFZGl0aW9u",
            "c01lc3NhZ2USHQoOcmVxdWlyZWRfZmllbGQYASABKAVCBaoBAggDEk0KD2Rl",
            "bGltaXRlZF9maWVsZBgCIAEoCzItLmxlZ2FjeV9mZWF0dXJlc191bml0dGVz",
            "dC5UZXN0RWRpdGlvbnNNZXNzYWdlQgWqAQIoAmIIZWRpdGlvbnNw6Ac="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::LegacyFeaturesUnittest.TestEditionsMessage), global::LegacyFeaturesUnittest.TestEditionsMessage.Parser, new[]{ "RequiredField", "DelimitedField" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TestEditionsMessage : pb::IMessage<TestEditionsMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TestEditionsMessage> _parser = new pb::MessageParser<TestEditionsMessage>(() => new TestEditionsMessage());
    private pb::UnknownFieldSet? _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TestEditionsMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LegacyFeaturesUnittest.UnittestLegacyFeaturesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TestEditionsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TestEditionsMessage(TestEditionsMessage other) : this() {
      _hasBits0 = other._hasBits0;
      requiredField_ = other.requiredField_;
      delimitedField_ = other.HasDelimitedField ? other.delimitedField_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TestEditionsMessage Clone() {
      return new TestEditionsMessage(this);
    }

    /// <summary>Field number for the "required_field" field.</summary>
    public const int RequiredFieldFieldNumber = 1;
    private readonly static int RequiredFieldDefaultValue = 0;

    private int requiredField_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int RequiredField {
      get { if ((_hasBits0 & 1) != 0) { return requiredField_; } else { return RequiredFieldDefaultValue; } }
      set {
        _hasBits0 |= 1;
        requiredField_ = value;
      }
    }
    /// <summary>Gets whether the "required_field" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasRequiredField {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "required_field" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRequiredField() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "delimited_field" field.</summary>
    public const int DelimitedFieldFieldNumber = 2;
    private global::LegacyFeaturesUnittest.TestEditionsMessage delimitedField_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::LegacyFeaturesUnittest.TestEditionsMessage? DelimitedField {
      get { return delimitedField_; }
      set {
        delimitedField_ = value;
      }
    }
    /// <summary>Gets whether the delimited_field field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDelimitedField {
      get { return delimitedField_ != null; }
    }
    /// <summary>Clears the value of the delimited_field field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDelimitedField() {
      delimitedField_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object? other) {
      return Equals(other as TestEditionsMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TestEditionsMessage? other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RequiredField != other.RequiredField) return false;
      if (!object.Equals(DelimitedField, other.DelimitedField)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasRequiredField) hash ^= RequiredField.GetHashCode();
      if (HasDelimitedField) hash ^= DelimitedField.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasRequiredField) {
        output.WriteRawTag(8);
        output.WriteInt32(RequiredField);
      }
      if (HasDelimitedField) {
        output.WriteRawTag(19);
        output.WriteGroup(DelimitedField);
        output.WriteRawTag(20);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasRequiredField) {
        output.WriteRawTag(8);
        output.WriteInt32(RequiredField);
      }
      if (HasDelimitedField) {
        output.WriteRawTag(19);
        output.WriteGroup(DelimitedField);
        output.WriteRawTag(20);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasRequiredField) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RequiredField);
      }
      if (HasDelimitedField) {
        size += 2 + pb::CodedOutputStream.ComputeGroupSize(DelimitedField);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TestEditionsMessage? other) {
      if (other == null) {
        return;
      }
      if (other.HasRequiredField) {
        RequiredField = other.RequiredField;
      }
      if (other.HasDelimitedField) {
        if (!HasDelimitedField) {
          DelimitedField = new global::LegacyFeaturesUnittest.TestEditionsMessage();
        }
        DelimitedField.MergeFrom(other.DelimitedField);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            RequiredField = input.ReadInt32();
            break;
          }
          case 19: {
            if (!HasDelimitedField) {
              DelimitedField = new global::LegacyFeaturesUnittest.TestEditionsMessage();
            }
            input.ReadGroup(DelimitedField);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            RequiredField = input.ReadInt32();
            break;
          }
          case 19: {
            if (!HasDelimitedField) {
              DelimitedField = new global::LegacyFeaturesUnittest.TestEditionsMessage();
            }
            input.ReadGroup(DelimitedField);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
