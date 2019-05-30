// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: claros_common_datetime.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace claros.common
{

    [global::ProtoBuf.ProtoContract()]
    public partial class DateTime : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public Date dateField { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public Time timeField { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public int timeZoneOffset { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"ticks")]
        public ulong Ticks { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public partial class Time : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"hours")]
            public uint Hours { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"minutes")]
            public uint Minutes { get; set; }

            [global::ProtoBuf.ProtoMember(3, Name = @"seconds")]
            public uint Seconds { get; set; }

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Date : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"year")]
            public uint Year { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"month")]
            public uint Month { get; set; }

            [global::ProtoBuf.ProtoMember(3, Name = @"day")]
            public uint Day { get; set; }

        }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
