// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: claros_operations_spreadsheet_worksheet_index.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace claros.common.form
{

    [global::ProtoBuf.ProtoContract()]
    public partial class WorksheetIndex : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Id { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2)]
        public uint worksheetVersion { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public global::claros.common.core.TimeWindow timeWindow { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public global::claros.common.core.TimeWindow utcTimeWindows { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public bool isInSpeed { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
