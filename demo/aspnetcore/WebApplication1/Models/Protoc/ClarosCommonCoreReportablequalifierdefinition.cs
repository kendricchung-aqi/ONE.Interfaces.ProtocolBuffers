// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: claros_common_core_reportablequalifierdefinition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Claros.Common.Core {

  /// <summary>Holder for reflection information generated from claros_common_core_reportablequalifierdefinition.proto</summary>
  public static partial class ClarosCommonCoreReportablequalifierdefinitionReflection {

    #region Descriptor
    /// <summary>File descriptor for claros_common_core_reportablequalifierdefinition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClarosCommonCoreReportablequalifierdefinitionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZjbGFyb3NfY29tbW9uX2NvcmVfcmVwb3J0YWJsZXF1YWxpZmllcmRlZmlu",
            "aXRpb24ucHJvdG8SEmNsYXJvcy5jb21tb24uY29yZRoxY2xhcm9zX2NvbW1v",
            "bl9jb3JlX3JlcG9ydGFibGVxdWFsaWZpZXJfdHlwZS5wcm90bxo7Y2xhcm9z",
            "X2NvbW1vbl9jb3JlX3JlcG9ydGFibGVxdWFsaWZpZXJkZWZpbml0aW9uX3R5",
            "cGUucHJvdG8i5gEKHVJlcG9ydGFibGVRdWFsaWZpZXJEZWZpbml0aW9uEkwK",
            "F3JlcG9ydGFibGVRdWFsaWZpZXJUeXBlGAEgASgOMisuY2xhcm9zLmNvbW1v",
            "bi5jb3JlLlJlcG9ydGFibGVRdWFsaWZpZXJUeXBlEmAKIXJlcG9ydGFibGVR",
            "dWFsaWZpZXJEZWZpbml0aW9uVHlwZRgCIAEoDjI1LmNsYXJvcy5jb21tb24u",
            "Y29yZS5SZXBvcnRhYmxlUXVhbGlmaWVyRGVmaW5pdGlvblR5cGUSFQoNY29u",
            "c3RhbnRWYWx1ZRgDIAEoAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Claros.Common.Core.ClarosCommonCoreReportablequalifierTypeReflection.Descriptor, global::Claros.Common.Core.ClarosCommonCoreReportablequalifierdefinitionTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Claros.Common.Core.ReportableQualifierDefinition), global::Claros.Common.Core.ReportableQualifierDefinition.Parser, new[]{ "ReportableQualifierType", "ReportableQualifierDefinitionType", "ConstantValue" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReportableQualifierDefinition : pb::IMessage<ReportableQualifierDefinition> {
    private static readonly pb::MessageParser<ReportableQualifierDefinition> _parser = new pb::MessageParser<ReportableQualifierDefinition>(() => new ReportableQualifierDefinition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReportableQualifierDefinition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Claros.Common.Core.ClarosCommonCoreReportablequalifierdefinitionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportableQualifierDefinition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportableQualifierDefinition(ReportableQualifierDefinition other) : this() {
      reportableQualifierType_ = other.reportableQualifierType_;
      reportableQualifierDefinitionType_ = other.reportableQualifierDefinitionType_;
      constantValue_ = other.constantValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportableQualifierDefinition Clone() {
      return new ReportableQualifierDefinition(this);
    }

    /// <summary>Field number for the "reportableQualifierType" field.</summary>
    public const int ReportableQualifierTypeFieldNumber = 1;
    private global::Claros.Common.Core.ReportableQualifierType reportableQualifierType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Claros.Common.Core.ReportableQualifierType ReportableQualifierType {
      get { return reportableQualifierType_; }
      set {
        reportableQualifierType_ = value;
      }
    }

    /// <summary>Field number for the "reportableQualifierDefinitionType" field.</summary>
    public const int ReportableQualifierDefinitionTypeFieldNumber = 2;
    private global::Claros.Common.Core.ReportableQualifierDefinitionType reportableQualifierDefinitionType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Claros.Common.Core.ReportableQualifierDefinitionType ReportableQualifierDefinitionType {
      get { return reportableQualifierDefinitionType_; }
      set {
        reportableQualifierDefinitionType_ = value;
      }
    }

    /// <summary>Field number for the "constantValue" field.</summary>
    public const int ConstantValueFieldNumber = 3;
    private double constantValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double ConstantValue {
      get { return constantValue_; }
      set {
        constantValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReportableQualifierDefinition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReportableQualifierDefinition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ReportableQualifierType != other.ReportableQualifierType) return false;
      if (ReportableQualifierDefinitionType != other.ReportableQualifierDefinitionType) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ConstantValue, other.ConstantValue)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ReportableQualifierType != 0) hash ^= ReportableQualifierType.GetHashCode();
      if (ReportableQualifierDefinitionType != 0) hash ^= ReportableQualifierDefinitionType.GetHashCode();
      if (ConstantValue != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ConstantValue);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ReportableQualifierType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ReportableQualifierType);
      }
      if (ReportableQualifierDefinitionType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ReportableQualifierDefinitionType);
      }
      if (ConstantValue != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(ConstantValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ReportableQualifierType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReportableQualifierType);
      }
      if (ReportableQualifierDefinitionType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReportableQualifierDefinitionType);
      }
      if (ConstantValue != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReportableQualifierDefinition other) {
      if (other == null) {
        return;
      }
      if (other.ReportableQualifierType != 0) {
        ReportableQualifierType = other.ReportableQualifierType;
      }
      if (other.ReportableQualifierDefinitionType != 0) {
        ReportableQualifierDefinitionType = other.ReportableQualifierDefinitionType;
      }
      if (other.ConstantValue != 0D) {
        ConstantValue = other.ConstantValue;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ReportableQualifierType = (global::Claros.Common.Core.ReportableQualifierType) input.ReadEnum();
            break;
          }
          case 16: {
            ReportableQualifierDefinitionType = (global::Claros.Common.Core.ReportableQualifierDefinitionType) input.ReadEnum();
            break;
          }
          case 25: {
            ConstantValue = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
