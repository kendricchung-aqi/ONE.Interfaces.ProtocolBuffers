// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: claros_instrument_measurement_scsensor_binding.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace claros.instrument
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SCSensorBinding : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"channel")]
        public uint Channel { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"tag")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Tag { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4)]
        public global::claros.common.core.ClarosDateTime validFrom { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public global::claros.common.core.ClarosDateTime validTo { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
