// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: claros_common_core_mobiletime.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Claros.Common.Core {

  /// <summary>Holder for reflection information generated from claros_common_core_mobiletime.proto</summary>
  public static partial class ClarosCommonCoreMobiletimeReflection {

    #region Descriptor
    /// <summary>File descriptor for claros_common_core_mobiletime.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClarosCommonCoreMobiletimeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNjbGFyb3NfY29tbW9uX2NvcmVfbW9iaWxldGltZS5wcm90bxISY2xhcm9z",
            "LmNvbW1vbi5jb3JlIj0KCk1vYmlsZVRpbWUSDQoFaG91cnMYASABKA0SDwoH",
            "bWludXRlcxgCIAEoDRIPCgdzZWNvbmRzGAMgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Claros.Common.Core.MobileTime), global::Claros.Common.Core.MobileTime.Parser, new[]{ "Hours", "Minutes", "Seconds" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MobileTime : pb::IMessage<MobileTime> {
    private static readonly pb::MessageParser<MobileTime> _parser = new pb::MessageParser<MobileTime>(() => new MobileTime());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MobileTime> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Claros.Common.Core.ClarosCommonCoreMobiletimeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MobileTime() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MobileTime(MobileTime other) : this() {
      hours_ = other.hours_;
      minutes_ = other.minutes_;
      seconds_ = other.seconds_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MobileTime Clone() {
      return new MobileTime(this);
    }

    /// <summary>Field number for the "hours" field.</summary>
    public const int HoursFieldNumber = 1;
    private uint hours_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Hours {
      get { return hours_; }
      set {
        hours_ = value;
      }
    }

    /// <summary>Field number for the "minutes" field.</summary>
    public const int MinutesFieldNumber = 2;
    private uint minutes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Minutes {
      get { return minutes_; }
      set {
        minutes_ = value;
      }
    }

    /// <summary>Field number for the "seconds" field.</summary>
    public const int SecondsFieldNumber = 3;
    private uint seconds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Seconds {
      get { return seconds_; }
      set {
        seconds_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MobileTime);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MobileTime other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Hours != other.Hours) return false;
      if (Minutes != other.Minutes) return false;
      if (Seconds != other.Seconds) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Hours != 0) hash ^= Hours.GetHashCode();
      if (Minutes != 0) hash ^= Minutes.GetHashCode();
      if (Seconds != 0) hash ^= Seconds.GetHashCode();
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
      if (Hours != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Hours);
      }
      if (Minutes != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Minutes);
      }
      if (Seconds != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Seconds);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Hours != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Hours);
      }
      if (Minutes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Minutes);
      }
      if (Seconds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Seconds);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MobileTime other) {
      if (other == null) {
        return;
      }
      if (other.Hours != 0) {
        Hours = other.Hours;
      }
      if (other.Minutes != 0) {
        Minutes = other.Minutes;
      }
      if (other.Seconds != 0) {
        Seconds = other.Seconds;
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
            Hours = input.ReadUInt32();
            break;
          }
          case 16: {
            Minutes = input.ReadUInt32();
            break;
          }
          case 24: {
            Seconds = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
