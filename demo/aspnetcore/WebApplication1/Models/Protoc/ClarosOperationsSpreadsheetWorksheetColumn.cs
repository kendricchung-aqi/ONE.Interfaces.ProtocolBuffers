// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: claros_operations_spreadsheet_worksheet_column.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Claros.Operations.Spreadsheet {

  /// <summary>Holder for reflection information generated from claros_operations_spreadsheet_worksheet_column.proto</summary>
  public static partial class ClarosOperationsSpreadsheetWorksheetColumnReflection {

    #region Descriptor
    /// <summary>File descriptor for claros_operations_spreadsheet_worksheet_column.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClarosOperationsSpreadsheetWorksheetColumnReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRjbGFyb3Nfb3BlcmF0aW9uc19zcHJlYWRzaGVldF93b3Jrc2hlZXRfY29s",
            "dW1uLnByb3RvEh1jbGFyb3Mub3BlcmF0aW9ucy5zcHJlYWRzaGVldBooY2xh",
            "cm9zX2NvbW1vbl9jb3JlX2RhdGFzb3VyY2VfdHlwZS5wcm90bxoeY2xhcm9z",
            "X2NvbW1vbl9jb3JlX2xpbWl0LnByb3RvGitjbGFyb3NfaW5zdHJ1bWVudF9t",
            "ZWFzdXJlbWVudF9iaW5kaW5nLnByb3RvGidjbGFyb3NfY29tbW9uX2NvbXB1",
            "dGF0aW9uX2JpbmRpbmcucHJvdG8aNmNsYXJvc19jb21tb25fY29yZV9yZXBv",
            "cnRhYmxlcXVhbGlmaWVyZGVmaW5pdGlvbi5wcm90byKEBAoGQ29sdW1uEhQK",
            "DGNvbHVtbk51bWJlchgBIAEoDRIMCgRuYW1lGAIgASgJEhMKC2Rlc2NyaXB0",
            "aW9uGAMgASgJEhMKC3BhcmFtZXRlcklkGAQgASgNEhUKDWRpc3BsYXlVbml0",
            "SWQYBSABKA0SEgoKbG9jYXRpb25JZBgGIAEoCRIQCghpc0FjdGl2ZRgHIAEo",
            "CBIpCgZsaW1pdHMYCCADKAsyGS5jbGFyb3MuY29tbW9uLmNvcmUuTGltaXQS",
            "OgoOZGF0YVNvdXJjZVR5cGUYCSABKA4yIi5jbGFyb3MuY29tbW9uLmNvcmUu",
            "RGF0YVNvdXJjZVR5cGUSVwocaW5zdHJ1bWVudE1lYXN1cmVtZW50QmluZGlu",
            "ZxgKIAEoCzIvLmNsYXJvcy5pbnN0cnVtZW50Lkluc3RydW1lbnRNZWFzdXJl",
            "bWVudEJpbmRpbmdIABJLChJjb21wdXRhdGlvbkJpbmRpbmcYCyABKAsyLS5j",
            "bGFyb3MuY29tbW9uLmNvbXB1dGF0aW9uLkNvbXB1dGF0aW9uQmluZGluZ0gA",
            "ElcKHHJlcG9ydGFibGVRdWFsaWZlckRlZmluaXRpb24YDCADKAsyMS5jbGFy",
            "b3MuY29tbW9uLmNvcmUuUmVwb3J0YWJsZVF1YWxpZmllckRlZmluaXRpb25C",
            "CQoHYmluZGluZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Claros.Common.Core.ClarosCommonCoreDatasourceTypeReflection.Descriptor, global::Claros.Common.Core.ClarosCommonCoreLimitReflection.Descriptor, global::Claros.Instrument.ClarosInstrumentMeasurementBindingReflection.Descriptor, global::Claros.Common.Computation.ClarosCommonComputationBindingReflection.Descriptor, global::Claros.Common.Core.ClarosCommonCoreReportablequalifierdefinitionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Claros.Operations.Spreadsheet.Column), global::Claros.Operations.Spreadsheet.Column.Parser, new[]{ "ColumnNumber", "Name", "Description", "ParameterId", "DisplayUnitId", "LocationId", "IsActive", "Limits", "DataSourceType", "InstrumentMeasurementBinding", "ComputationBinding", "ReportableQualiferDefinition" }, new[]{ "Binding" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Column : pb::IMessage<Column> {
    private static readonly pb::MessageParser<Column> _parser = new pb::MessageParser<Column>(() => new Column());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Column> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Claros.Operations.Spreadsheet.ClarosOperationsSpreadsheetWorksheetColumnReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Column() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Column(Column other) : this() {
      columnNumber_ = other.columnNumber_;
      name_ = other.name_;
      description_ = other.description_;
      parameterId_ = other.parameterId_;
      displayUnitId_ = other.displayUnitId_;
      locationId_ = other.locationId_;
      isActive_ = other.isActive_;
      limits_ = other.limits_.Clone();
      dataSourceType_ = other.dataSourceType_;
      reportableQualiferDefinition_ = other.reportableQualiferDefinition_.Clone();
      switch (other.BindingCase) {
        case BindingOneofCase.InstrumentMeasurementBinding:
          InstrumentMeasurementBinding = other.InstrumentMeasurementBinding.Clone();
          break;
        case BindingOneofCase.ComputationBinding:
          ComputationBinding = other.ComputationBinding.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Column Clone() {
      return new Column(this);
    }

    /// <summary>Field number for the "columnNumber" field.</summary>
    public const int ColumnNumberFieldNumber = 1;
    private uint columnNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ColumnNumber {
      get { return columnNumber_; }
      set {
        columnNumber_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parameterId" field.</summary>
    public const int ParameterIdFieldNumber = 4;
    private uint parameterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ParameterId {
      get { return parameterId_; }
      set {
        parameterId_ = value;
      }
    }

    /// <summary>Field number for the "displayUnitId" field.</summary>
    public const int DisplayUnitIdFieldNumber = 5;
    private uint displayUnitId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint DisplayUnitId {
      get { return displayUnitId_; }
      set {
        displayUnitId_ = value;
      }
    }

    /// <summary>Field number for the "locationId" field.</summary>
    public const int LocationIdFieldNumber = 6;
    private string locationId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LocationId {
      get { return locationId_; }
      set {
        locationId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "isActive" field.</summary>
    public const int IsActiveFieldNumber = 7;
    private bool isActive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsActive {
      get { return isActive_; }
      set {
        isActive_ = value;
      }
    }

    /// <summary>Field number for the "limits" field.</summary>
    public const int LimitsFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Claros.Common.Core.Limit> _repeated_limits_codec
        = pb::FieldCodec.ForMessage(66, global::Claros.Common.Core.Limit.Parser);
    private readonly pbc::RepeatedField<global::Claros.Common.Core.Limit> limits_ = new pbc::RepeatedField<global::Claros.Common.Core.Limit>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Claros.Common.Core.Limit> Limits {
      get { return limits_; }
    }

    /// <summary>Field number for the "dataSourceType" field.</summary>
    public const int DataSourceTypeFieldNumber = 9;
    private global::Claros.Common.Core.DataSourceType dataSourceType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Claros.Common.Core.DataSourceType DataSourceType {
      get { return dataSourceType_; }
      set {
        dataSourceType_ = value;
      }
    }

    /// <summary>Field number for the "instrumentMeasurementBinding" field.</summary>
    public const int InstrumentMeasurementBindingFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Claros.Instrument.InstrumentMeasurementBinding InstrumentMeasurementBinding {
      get { return bindingCase_ == BindingOneofCase.InstrumentMeasurementBinding ? (global::Claros.Instrument.InstrumentMeasurementBinding) binding_ : null; }
      set {
        binding_ = value;
        bindingCase_ = value == null ? BindingOneofCase.None : BindingOneofCase.InstrumentMeasurementBinding;
      }
    }

    /// <summary>Field number for the "computationBinding" field.</summary>
    public const int ComputationBindingFieldNumber = 11;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Claros.Common.Computation.ComputationBinding ComputationBinding {
      get { return bindingCase_ == BindingOneofCase.ComputationBinding ? (global::Claros.Common.Computation.ComputationBinding) binding_ : null; }
      set {
        binding_ = value;
        bindingCase_ = value == null ? BindingOneofCase.None : BindingOneofCase.ComputationBinding;
      }
    }

    /// <summary>Field number for the "reportableQualiferDefinition" field.</summary>
    public const int ReportableQualiferDefinitionFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Claros.Common.Core.ReportableQualifierDefinition> _repeated_reportableQualiferDefinition_codec
        = pb::FieldCodec.ForMessage(98, global::Claros.Common.Core.ReportableQualifierDefinition.Parser);
    private readonly pbc::RepeatedField<global::Claros.Common.Core.ReportableQualifierDefinition> reportableQualiferDefinition_ = new pbc::RepeatedField<global::Claros.Common.Core.ReportableQualifierDefinition>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Claros.Common.Core.ReportableQualifierDefinition> ReportableQualiferDefinition {
      get { return reportableQualiferDefinition_; }
    }

    private object binding_;
    /// <summary>Enum of possible cases for the "binding" oneof.</summary>
    public enum BindingOneofCase {
      None = 0,
      InstrumentMeasurementBinding = 10,
      ComputationBinding = 11,
    }
    private BindingOneofCase bindingCase_ = BindingOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BindingOneofCase BindingCase {
      get { return bindingCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearBinding() {
      bindingCase_ = BindingOneofCase.None;
      binding_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Column);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Column other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ColumnNumber != other.ColumnNumber) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (ParameterId != other.ParameterId) return false;
      if (DisplayUnitId != other.DisplayUnitId) return false;
      if (LocationId != other.LocationId) return false;
      if (IsActive != other.IsActive) return false;
      if(!limits_.Equals(other.limits_)) return false;
      if (DataSourceType != other.DataSourceType) return false;
      if (!object.Equals(InstrumentMeasurementBinding, other.InstrumentMeasurementBinding)) return false;
      if (!object.Equals(ComputationBinding, other.ComputationBinding)) return false;
      if(!reportableQualiferDefinition_.Equals(other.reportableQualiferDefinition_)) return false;
      if (BindingCase != other.BindingCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ColumnNumber != 0) hash ^= ColumnNumber.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (ParameterId != 0) hash ^= ParameterId.GetHashCode();
      if (DisplayUnitId != 0) hash ^= DisplayUnitId.GetHashCode();
      if (LocationId.Length != 0) hash ^= LocationId.GetHashCode();
      if (IsActive != false) hash ^= IsActive.GetHashCode();
      hash ^= limits_.GetHashCode();
      if (DataSourceType != 0) hash ^= DataSourceType.GetHashCode();
      if (bindingCase_ == BindingOneofCase.InstrumentMeasurementBinding) hash ^= InstrumentMeasurementBinding.GetHashCode();
      if (bindingCase_ == BindingOneofCase.ComputationBinding) hash ^= ComputationBinding.GetHashCode();
      hash ^= reportableQualiferDefinition_.GetHashCode();
      hash ^= (int) bindingCase_;
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
      if (ColumnNumber != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ColumnNumber);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (ParameterId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ParameterId);
      }
      if (DisplayUnitId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DisplayUnitId);
      }
      if (LocationId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(LocationId);
      }
      if (IsActive != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsActive);
      }
      limits_.WriteTo(output, _repeated_limits_codec);
      if (DataSourceType != 0) {
        output.WriteRawTag(72);
        output.WriteEnum((int) DataSourceType);
      }
      if (bindingCase_ == BindingOneofCase.InstrumentMeasurementBinding) {
        output.WriteRawTag(82);
        output.WriteMessage(InstrumentMeasurementBinding);
      }
      if (bindingCase_ == BindingOneofCase.ComputationBinding) {
        output.WriteRawTag(90);
        output.WriteMessage(ComputationBinding);
      }
      reportableQualiferDefinition_.WriteTo(output, _repeated_reportableQualiferDefinition_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ColumnNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ColumnNumber);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (ParameterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParameterId);
      }
      if (DisplayUnitId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DisplayUnitId);
      }
      if (LocationId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LocationId);
      }
      if (IsActive != false) {
        size += 1 + 1;
      }
      size += limits_.CalculateSize(_repeated_limits_codec);
      if (DataSourceType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DataSourceType);
      }
      if (bindingCase_ == BindingOneofCase.InstrumentMeasurementBinding) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InstrumentMeasurementBinding);
      }
      if (bindingCase_ == BindingOneofCase.ComputationBinding) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ComputationBinding);
      }
      size += reportableQualiferDefinition_.CalculateSize(_repeated_reportableQualiferDefinition_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Column other) {
      if (other == null) {
        return;
      }
      if (other.ColumnNumber != 0) {
        ColumnNumber = other.ColumnNumber;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.ParameterId != 0) {
        ParameterId = other.ParameterId;
      }
      if (other.DisplayUnitId != 0) {
        DisplayUnitId = other.DisplayUnitId;
      }
      if (other.LocationId.Length != 0) {
        LocationId = other.LocationId;
      }
      if (other.IsActive != false) {
        IsActive = other.IsActive;
      }
      limits_.Add(other.limits_);
      if (other.DataSourceType != 0) {
        DataSourceType = other.DataSourceType;
      }
      reportableQualiferDefinition_.Add(other.reportableQualiferDefinition_);
      switch (other.BindingCase) {
        case BindingOneofCase.InstrumentMeasurementBinding:
          if (InstrumentMeasurementBinding == null) {
            InstrumentMeasurementBinding = new global::Claros.Instrument.InstrumentMeasurementBinding();
          }
          InstrumentMeasurementBinding.MergeFrom(other.InstrumentMeasurementBinding);
          break;
        case BindingOneofCase.ComputationBinding:
          if (ComputationBinding == null) {
            ComputationBinding = new global::Claros.Common.Computation.ComputationBinding();
          }
          ComputationBinding.MergeFrom(other.ComputationBinding);
          break;
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
            ColumnNumber = input.ReadUInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 32: {
            ParameterId = input.ReadUInt32();
            break;
          }
          case 40: {
            DisplayUnitId = input.ReadUInt32();
            break;
          }
          case 50: {
            LocationId = input.ReadString();
            break;
          }
          case 56: {
            IsActive = input.ReadBool();
            break;
          }
          case 66: {
            limits_.AddEntriesFrom(input, _repeated_limits_codec);
            break;
          }
          case 72: {
            DataSourceType = (global::Claros.Common.Core.DataSourceType) input.ReadEnum();
            break;
          }
          case 82: {
            global::Claros.Instrument.InstrumentMeasurementBinding subBuilder = new global::Claros.Instrument.InstrumentMeasurementBinding();
            if (bindingCase_ == BindingOneofCase.InstrumentMeasurementBinding) {
              subBuilder.MergeFrom(InstrumentMeasurementBinding);
            }
            input.ReadMessage(subBuilder);
            InstrumentMeasurementBinding = subBuilder;
            break;
          }
          case 90: {
            global::Claros.Common.Computation.ComputationBinding subBuilder = new global::Claros.Common.Computation.ComputationBinding();
            if (bindingCase_ == BindingOneofCase.ComputationBinding) {
              subBuilder.MergeFrom(ComputationBinding);
            }
            input.ReadMessage(subBuilder);
            ComputationBinding = subBuilder;
            break;
          }
          case 98: {
            reportableQualiferDefinition_.AddEntriesFrom(input, _repeated_reportableQualiferDefinition_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
