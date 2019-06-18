// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: claros_instrument_prognosys.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace claros.protoc.Instrument {

  /// <summary>Holder for reflection information generated from claros_instrument_prognosys.proto</summary>
  public static partial class ClarosInstrumentPrognosysReflection {

    #region Descriptor
    /// <summary>File descriptor for claros_instrument_prognosys.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClarosInstrumentPrognosysReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFjbGFyb3NfaW5zdHJ1bWVudF9wcm9nbm9zeXMucHJvdG8SEWNsYXJvcy5p",
            "bnN0cnVtZW50IjoKDVByb2dub3N5c0RhdGESCgoCaWQYASABKAUSDwoHcGVy",
            "Y2VudBgCIAEoAhIMCgRkYXlzGAMgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::claros.protoc.Instrument.PrognosysData), global::claros.protoc.Instrument.PrognosysData.Parser, new[]{ "Id", "Percent", "Days" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PrognosysData : pb::IMessage<PrognosysData> {
    private static readonly pb::MessageParser<PrognosysData> _parser = new pb::MessageParser<PrognosysData>(() => new PrognosysData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PrognosysData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::claros.protoc.Instrument.ClarosInstrumentPrognosysReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrognosysData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrognosysData(PrognosysData other) : this() {
      id_ = other.id_;
      percent_ = other.percent_;
      days_ = other.days_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrognosysData Clone() {
      return new PrognosysData(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "percent" field.</summary>
    public const int PercentFieldNumber = 2;
    private float percent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Percent {
      get { return percent_; }
      set {
        percent_ = value;
      }
    }

    /// <summary>Field number for the "days" field.</summary>
    public const int DaysFieldNumber = 3;
    private int days_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Days {
      get { return days_; }
      set {
        days_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PrognosysData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PrognosysData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Percent, other.Percent)) return false;
      if (Days != other.Days) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Percent != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Percent);
      if (Days != 0) hash ^= Days.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Percent != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Percent);
      }
      if (Days != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Days);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Percent != 0F) {
        size += 1 + 4;
      }
      if (Days != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Days);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PrognosysData other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Percent != 0F) {
        Percent = other.Percent;
      }
      if (other.Days != 0) {
        Days = other.Days;
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
            Id = input.ReadInt32();
            break;
          }
          case 21: {
            Percent = input.ReadFloat();
            break;
          }
          case 24: {
            Days = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
