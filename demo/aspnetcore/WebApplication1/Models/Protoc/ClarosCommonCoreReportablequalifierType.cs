// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: claros_common_core_reportablequalifier_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace claros.protoc.Common.Core {

  /// <summary>Holder for reflection information generated from claros_common_core_reportablequalifier_type.proto</summary>
  public static partial class ClarosCommonCoreReportablequalifierTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for claros_common_core_reportablequalifier_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClarosCommonCoreReportablequalifierTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFjbGFyb3NfY29tbW9uX2NvcmVfcmVwb3J0YWJsZXF1YWxpZmllcl90eXBl",
            "LnByb3RvEhJjbGFyb3MuY29tbW9uLmNvcmUqrAEKF1JlcG9ydGFibGVRdWFs",
            "aWZpZXJUeXBlEg4KClJRX1VOS05PV04QABIQCgxSUV9OT05ERVRFQ1QQARIP",
            "CgtSUV9FU1RJTUFURRACEhsKF1JRX0RFVEVDVE5PTlFVQUxJRklBQkxFEAMS",
            "EgoOUlFfR1JFQVRFUlRIQU4QBBIPCgtSUV9MRVNTVEhBThAFEhwKGFJRX1RP",
            "T19OVU1FUk9VU19UT19DT1VOVBAGYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::claros.protoc.Common.Core.ReportableQualifierType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ReportableQualifierType {
    [pbr::OriginalName("RQ_UNKNOWN")] RqUnknown = 0,
    [pbr::OriginalName("RQ_NONDETECT")] RqNondetect = 1,
    [pbr::OriginalName("RQ_ESTIMATE")] RqEstimate = 2,
    [pbr::OriginalName("RQ_DETECTNONQUALIFIABLE")] RqDetectnonqualifiable = 3,
    [pbr::OriginalName("RQ_GREATERTHAN")] RqGreaterthan = 4,
    [pbr::OriginalName("RQ_LESSTHAN")] RqLessthan = 5,
    [pbr::OriginalName("RQ_TOO_NUMEROUS_TO_COUNT")] RqTooNumerousToCount = 6,
  }

  #endregion

}

#endregion Designer generated code
