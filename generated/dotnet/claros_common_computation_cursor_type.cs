// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: claros_common_computation_cursor_type.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace claros.common.computation
{

    [global::ProtoBuf.ProtoContract()]
    public enum ComputationCursorType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"COMPUTATION_CURSOR_UNKNOWN")]
        ComputationCursorUnknown = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"COMPUTATION_CURSOR_CURRENT")]
        ComputationCursorCurrent = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"COMPUTATION_CURSOR_PREVIOUS")]
        ComputationCursorPrevious = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"COMPUTATION_CURSOR_NEXT")]
        ComputationCursorNext = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"COMPUTATION_CURSOR_LAST")]
        ComputationCursorLast = 5,
        [global::ProtoBuf.ProtoEnum(Name = @"COMPUTATION_CURSOR_ABSOLUTE")]
        ComputationCursorAbsolute = 6,
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
