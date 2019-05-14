// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: claros_common_gis_multi_point3d.proto

// This CPP symbol can be defined to use imports that match up to the framework
// imports needed when using CocoaPods.
#if !defined(GPB_USE_PROTOBUF_FRAMEWORK_IMPORTS)
 #define GPB_USE_PROTOBUF_FRAMEWORK_IMPORTS 0
#endif

#if GPB_USE_PROTOBUF_FRAMEWORK_IMPORTS
 #import <Protobuf/GPBProtocolBuffers_RuntimeSupport.h>
#else
 #import "GPBProtocolBuffers_RuntimeSupport.h"
#endif

#import "ClarosCommonGisMultiPoint3D.pbobjc.h"
#import "ClarosCommonGisPoint3D.pbobjc.h"
// @@protoc_insertion_point(imports)

#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wdeprecated-declarations"

#pragma mark - ClarosCommonGisMultiPoint3DRoot

@implementation ClarosCommonGisMultiPoint3DRoot

// No extensions in the file and none of the imports (direct or indirect)
// defined extensions, so no need to generate +extensionRegistry.

@end

#pragma mark - ClarosCommonGisMultiPoint3DRoot_FileDescriptor

static GPBFileDescriptor *ClarosCommonGisMultiPoint3DRoot_FileDescriptor(void) {
  // This is called by +initialize so there is no need to worry
  // about thread safety of the singleton.
  static GPBFileDescriptor *descriptor = NULL;
  if (!descriptor) {
    GPB_DEBUG_CHECK_RUNTIME_VERSIONS();
    descriptor = [[GPBFileDescriptor alloc] initWithPackage:@"claros.common.gis"
                                                     syntax:GPBFileSyntaxProto3];
  }
  return descriptor;
}

#pragma mark - MultiPoint3D

@implementation MultiPoint3D

@dynamic pointArray, pointArray_Count;

typedef struct MultiPoint3D__storage_ {
  uint32_t _has_storage_[1];
  NSMutableArray *pointArray;
} MultiPoint3D__storage_;

// This method is threadsafe because it is initially called
// in +initialize for each subclass.
+ (GPBDescriptor *)descriptor {
  static GPBDescriptor *descriptor = nil;
  if (!descriptor) {
    static GPBMessageFieldDescription fields[] = {
      {
        .name = "pointArray",
        .dataTypeSpecific.className = GPBStringifySymbol(Point3D),
        .number = MultiPoint3D_FieldNumber_PointArray,
        .hasIndex = GPBNoHasBit,
        .offset = (uint32_t)offsetof(MultiPoint3D__storage_, pointArray),
        .flags = GPBFieldRepeated,
        .dataType = GPBDataTypeMessage,
      },
    };
    GPBDescriptor *localDescriptor =
        [GPBDescriptor allocDescriptorForClass:[MultiPoint3D class]
                                     rootClass:[ClarosCommonGisMultiPoint3DRoot class]
                                          file:ClarosCommonGisMultiPoint3DRoot_FileDescriptor()
                                        fields:fields
                                    fieldCount:(uint32_t)(sizeof(fields) / sizeof(GPBMessageFieldDescription))
                                   storageSize:sizeof(MultiPoint3D__storage_)
                                         flags:GPBDescriptorInitializationFlag_None];
    #if defined(DEBUG) && DEBUG
      NSAssert(descriptor == nil, @"Startup recursed!");
    #endif  // DEBUG
    descriptor = localDescriptor;
  }
  return descriptor;
}

@end


#pragma clang diagnostic pop

// @@protoc_insertion_point(global_scope)
