// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: claros_operations_spreadsheet_spreadsheet.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace claros.operations.spreadsheet
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Spreadsheet : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string locationId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"timeDefinition")]
        public global::System.Collections.Generic.List<global::claros.instrument.spreadsheet.SpreadsheetDefinition> timeDefinitions { get; } = new global::System.Collections.Generic.List<global::claros.instrument.spreadsheet.SpreadsheetDefinition>();

        [global::ProtoBuf.ProtoMember(4, Name = @"worksheet")]
        public global::System.Collections.Generic.List<Worksheet> Worksheets { get; } = new global::System.Collections.Generic.List<Worksheet>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
