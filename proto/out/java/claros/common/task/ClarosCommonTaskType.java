// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: claros_common_task_type.proto

package claros.common.task;

public final class ClarosCommonTaskType {
  private ClarosCommonTaskType() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  /**
   * Protobuf enum {@code claros.common.task.TaskType}
   */
  public enum TaskType
      implements com.google.protobuf.ProtocolMessageEnum {
    /**
     * <code>TASKTYPE_UNKNOWN = 0;</code>
     */
    TASKTYPE_UNKNOWN(0),
    /**
     * <code>TASKTYPE_INSTRUMENT_MAINTENANCE = 1;</code>
     */
    TASKTYPE_INSTRUMENT_MAINTENANCE(1),
    UNRECOGNIZED(-1),
    ;

    /**
     * <code>TASKTYPE_UNKNOWN = 0;</code>
     */
    public static final int TASKTYPE_UNKNOWN_VALUE = 0;
    /**
     * <code>TASKTYPE_INSTRUMENT_MAINTENANCE = 1;</code>
     */
    public static final int TASKTYPE_INSTRUMENT_MAINTENANCE_VALUE = 1;


    public final int getNumber() {
      if (this == UNRECOGNIZED) {
        throw new java.lang.IllegalArgumentException(
            "Can't get the number of an unknown enum value.");
      }
      return value;
    }

    /**
     * @deprecated Use {@link #forNumber(int)} instead.
     */
    @java.lang.Deprecated
    public static TaskType valueOf(int value) {
      return forNumber(value);
    }

    public static TaskType forNumber(int value) {
      switch (value) {
        case 0: return TASKTYPE_UNKNOWN;
        case 1: return TASKTYPE_INSTRUMENT_MAINTENANCE;
        default: return null;
      }
    }

    public static com.google.protobuf.Internal.EnumLiteMap<TaskType>
        internalGetValueMap() {
      return internalValueMap;
    }
    private static final com.google.protobuf.Internal.EnumLiteMap<
        TaskType> internalValueMap =
          new com.google.protobuf.Internal.EnumLiteMap<TaskType>() {
            public TaskType findValueByNumber(int number) {
              return TaskType.forNumber(number);
            }
          };

    public final com.google.protobuf.Descriptors.EnumValueDescriptor
        getValueDescriptor() {
      return getDescriptor().getValues().get(ordinal());
    }
    public final com.google.protobuf.Descriptors.EnumDescriptor
        getDescriptorForType() {
      return getDescriptor();
    }
    public static final com.google.protobuf.Descriptors.EnumDescriptor
        getDescriptor() {
      return claros.common.task.ClarosCommonTaskType.getDescriptor().getEnumTypes().get(0);
    }

    private static final TaskType[] VALUES = values();

    public static TaskType valueOf(
        com.google.protobuf.Descriptors.EnumValueDescriptor desc) {
      if (desc.getType() != getDescriptor()) {
        throw new java.lang.IllegalArgumentException(
          "EnumValueDescriptor is not for this type.");
      }
      if (desc.getIndex() == -1) {
        return UNRECOGNIZED;
      }
      return VALUES[desc.getIndex()];
    }

    private final int value;

    private TaskType(int value) {
      this.value = value;
    }

    // @@protoc_insertion_point(enum_scope:claros.common.task.TaskType)
  }


  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n\035claros_common_task_type.proto\022\022claros." +
      "common.task*E\n\010TaskType\022\024\n\020TASKTYPE_UNKN" +
      "OWN\020\000\022#\n\037TASKTYPE_INSTRUMENT_MAINTENANCE" +
      "\020\001b\006proto3"
    };
    com.google.protobuf.Descriptors.FileDescriptor.InternalDescriptorAssigner assigner =
        new com.google.protobuf.Descriptors.FileDescriptor.    InternalDescriptorAssigner() {
          public com.google.protobuf.ExtensionRegistry assignDescriptors(
              com.google.protobuf.Descriptors.FileDescriptor root) {
            descriptor = root;
            return null;
          }
        };
    com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
        }, assigner);
  }

  // @@protoc_insertion_point(outer_class_scope)
}
