// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: claros_operations_spreadsheet_worksheet_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace claros.protoc.Operations.Spreadsheet {

  /// <summary>Holder for reflection information generated from claros_operations_spreadsheet_worksheet_type.proto</summary>
  public static partial class ClarosOperationsSpreadsheetWorksheetTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for claros_operations_spreadsheet_worksheet_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClarosOperationsSpreadsheetWorksheetTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJjbGFyb3Nfb3BlcmF0aW9uc19zcHJlYWRzaGVldF93b3Jrc2hlZXRfdHlw",
            "ZS5wcm90bxIdY2xhcm9zLm9wZXJhdGlvbnMuc3ByZWFkc2hlZXQqYQoNV29y",
            "a3NoZWV0VHlwZRINCglXX1VOS05PV04QABIUChBXX0ZJRlRFRU5fTUlOVVRF",
            "EAESDwoLV19GT1VSX0hPVVIQAhILCgdXX0RBSUxZEAMSDQoJV19NT05USExZ",
            "EARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::claros.protoc.Operations.Spreadsheet.WorksheetType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum WorksheetType {
    [pbr::OriginalName("W_UNKNOWN")] WUnknown = 0,
    [pbr::OriginalName("W_FIFTEEN_MINUTE")] WFifteenMinute = 1,
    [pbr::OriginalName("W_FOUR_HOUR")] WFourHour = 2,
    [pbr::OriginalName("W_DAILY")] WDaily = 3,
    [pbr::OriginalName("W_MONTHLY")] WMonthly = 4,
  }

  #endregion

}

#endregion Designer generated code
