// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: claros_instrument_measurement.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace claros.instrument
{

    [global::ProtoBuf.ProtoContract()]
    public partial class InstrumentMeasurement : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string instrumentMeasurementId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"channel")]
        public int Channel { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string fusionId { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"measurement")]
        public global::claros.common.core.Measurement Measurement { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public InstrumentMeasurement supportingMeasurements { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"gis")]
        public global::claros.common.gis.Gis Gis { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string measurementDataExtended { get; set; } = "";

        [global::ProtoBuf.ProtoMember(8)]
        public InstrumentEvent measurementEvent { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
