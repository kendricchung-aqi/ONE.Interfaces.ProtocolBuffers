// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: claros_common_core_networkdata.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace claros.common.core
{

    [global::ProtoBuf.ProtoContract()]
    public partial class NetworkData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"responses")]
        public global::System.Collections.Generic.List<Response> Responses { get; } = new global::System.Collections.Generic.List<Response>();

        [global::ProtoBuf.ProtoContract()]
        public partial class Response : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(2)]
            public global::claros.common.form.FormTemplate formTemplate
            {
                get { return __pbn__response_one_of.Is(2) ? ((global::claros.common.form.FormTemplate)__pbn__response_one_of.Object) : default; }
                set { __pbn__response_one_of = new global::ProtoBuf.DiscriminatedUnionObject(2, value); }
            }
            public bool ShouldSerializeformTemplate() => __pbn__response_one_of.Is(2);
            public void ResetformTemplate() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__response_one_of, 2);

            private global::ProtoBuf.DiscriminatedUnionObject __pbn__response_one_of;

            [global::ProtoBuf.ProtoMember(3, Name = @"form")]
            public global::claros.common.form.Form Form
            {
                get { return __pbn__response_one_of.Is(3) ? ((global::claros.common.form.Form)__pbn__response_one_of.Object) : default; }
                set { __pbn__response_one_of = new global::ProtoBuf.DiscriminatedUnionObject(3, value); }
            }
            public bool ShouldSerializeForm() => __pbn__response_one_of.Is(3);
            public void ResetForm() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__response_one_of, 3);

            [global::ProtoBuf.ProtoMember(4)]
            public ClarosDateTime dateTime
            {
                get { return __pbn__response_one_of.Is(4) ? ((ClarosDateTime)__pbn__response_one_of.Object) : default; }
                set { __pbn__response_one_of = new global::ProtoBuf.DiscriminatedUnionObject(4, value); }
            }
            public bool ShouldSerializedateTime() => __pbn__response_one_of.Is(4);
            public void ResetdateTime() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__response_one_of, 4);

            [global::ProtoBuf.ProtoMember(5, Name = @"note")]
            public Note Note
            {
                get { return __pbn__response_one_of.Is(5) ? ((Note)__pbn__response_one_of.Object) : default; }
                set { __pbn__response_one_of = new global::ProtoBuf.DiscriminatedUnionObject(5, value); }
            }
            public bool ShouldSerializeNote() => __pbn__response_one_of.Is(5);
            public void ResetNote() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__response_one_of, 5);

        }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
