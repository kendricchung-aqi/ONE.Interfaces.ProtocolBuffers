// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: claros_instrument_event_data_metadata.proto

#ifndef PROTOBUF_INCLUDED_claros_5finstrument_5fevent_5fdata_5fmetadata_2eproto
#define PROTOBUF_INCLUDED_claros_5finstrument_5fevent_5fdata_5fmetadata_2eproto

#include <limits>
#include <string>

#include <google/protobuf/port_def.inc>
#if PROTOBUF_VERSION < 3007000
#error This file was generated by a newer version of protoc which is
#error incompatible with your Protocol Buffer headers. Please update
#error your headers.
#endif
#if 3007001 < PROTOBUF_MIN_PROTOC_VERSION
#error This file was generated by an older version of protoc which is
#error incompatible with your Protocol Buffer headers. Please
#error regenerate this file with a newer version of protoc.
#endif

#include <google/protobuf/port_undef.inc>
#include <google/protobuf/io/coded_stream.h>
#include <google/protobuf/arena.h>
#include <google/protobuf/arenastring.h>
#include <google/protobuf/generated_message_table_driven.h>
#include <google/protobuf/generated_message_util.h>
#include <google/protobuf/inlined_string_field.h>
#include <google/protobuf/metadata.h>
#include <google/protobuf/message.h>
#include <google/protobuf/repeated_field.h>  // IWYU pragma: export
#include <google/protobuf/extension_set.h>  // IWYU pragma: export
#include <google/protobuf/unknown_field_set.h>
// @@protoc_insertion_point(includes)
#include <google/protobuf/port_def.inc>
#define PROTOBUF_INTERNAL_EXPORT_claros_5finstrument_5fevent_5fdata_5fmetadata_2eproto

// Internal implementation detail -- do not use these members.
struct TableStruct_claros_5finstrument_5fevent_5fdata_5fmetadata_2eproto {
  static const ::google::protobuf::internal::ParseTableField entries[]
    PROTOBUF_SECTION_VARIABLE(protodesc_cold);
  static const ::google::protobuf::internal::AuxillaryParseTableField aux[]
    PROTOBUF_SECTION_VARIABLE(protodesc_cold);
  static const ::google::protobuf::internal::ParseTable schema[1]
    PROTOBUF_SECTION_VARIABLE(protodesc_cold);
  static const ::google::protobuf::internal::FieldMetadata field_metadata[];
  static const ::google::protobuf::internal::SerializationTable serialization_table[];
  static const ::google::protobuf::uint32 offsets[];
};
void AddDescriptors_claros_5finstrument_5fevent_5fdata_5fmetadata_2eproto();
namespace claros {
namespace instrument {
namespace event {
class EventDataMetaData;
class EventDataMetaDataDefaultTypeInternal;
extern EventDataMetaDataDefaultTypeInternal _EventDataMetaData_default_instance_;
}  // namespace event
}  // namespace instrument
}  // namespace claros
namespace google {
namespace protobuf {
template<> ::claros::instrument::event::EventDataMetaData* Arena::CreateMaybeMessage<::claros::instrument::event::EventDataMetaData>(Arena*);
}  // namespace protobuf
}  // namespace google
namespace claros {
namespace instrument {
namespace event {

// ===================================================================

class EventDataMetaData :
    public ::google::protobuf::Message /* @@protoc_insertion_point(class_definition:claros.instrument.event.EventDataMetaData) */ {
 public:
  EventDataMetaData();
  virtual ~EventDataMetaData();

  EventDataMetaData(const EventDataMetaData& from);

  inline EventDataMetaData& operator=(const EventDataMetaData& from) {
    CopyFrom(from);
    return *this;
  }
  #if LANG_CXX11
  EventDataMetaData(EventDataMetaData&& from) noexcept
    : EventDataMetaData() {
    *this = ::std::move(from);
  }

  inline EventDataMetaData& operator=(EventDataMetaData&& from) noexcept {
    if (GetArenaNoVirtual() == from.GetArenaNoVirtual()) {
      if (this != &from) InternalSwap(&from);
    } else {
      CopyFrom(from);
    }
    return *this;
  }
  #endif
  static const ::google::protobuf::Descriptor* descriptor() {
    return default_instance().GetDescriptor();
  }
  static const EventDataMetaData& default_instance();

  static void InitAsDefaultInstance();  // FOR INTERNAL USE ONLY
  static inline const EventDataMetaData* internal_default_instance() {
    return reinterpret_cast<const EventDataMetaData*>(
               &_EventDataMetaData_default_instance_);
  }
  static constexpr int kIndexInFileMessages =
    0;

  void Swap(EventDataMetaData* other);
  friend void swap(EventDataMetaData& a, EventDataMetaData& b) {
    a.Swap(&b);
  }

  // implements Message ----------------------------------------------

  inline EventDataMetaData* New() const final {
    return CreateMaybeMessage<EventDataMetaData>(nullptr);
  }

  EventDataMetaData* New(::google::protobuf::Arena* arena) const final {
    return CreateMaybeMessage<EventDataMetaData>(arena);
  }
  void CopyFrom(const ::google::protobuf::Message& from) final;
  void MergeFrom(const ::google::protobuf::Message& from) final;
  void CopyFrom(const EventDataMetaData& from);
  void MergeFrom(const EventDataMetaData& from);
  PROTOBUF_ATTRIBUTE_REINITIALIZES void Clear() final;
  bool IsInitialized() const final;

  size_t ByteSizeLong() const final;
  #if GOOGLE_PROTOBUF_ENABLE_EXPERIMENTAL_PARSER
  static const char* _InternalParse(const char* begin, const char* end, void* object, ::google::protobuf::internal::ParseContext* ctx);
  ::google::protobuf::internal::ParseFunc _ParseFunc() const final { return _InternalParse; }
  #else
  bool MergePartialFromCodedStream(
      ::google::protobuf::io::CodedInputStream* input) final;
  #endif  // GOOGLE_PROTOBUF_ENABLE_EXPERIMENTAL_PARSER
  void SerializeWithCachedSizes(
      ::google::protobuf::io::CodedOutputStream* output) const final;
  ::google::protobuf::uint8* InternalSerializeWithCachedSizesToArray(
      ::google::protobuf::uint8* target) const final;
  int GetCachedSize() const final { return _cached_size_.Get(); }

  private:
  void SharedCtor();
  void SharedDtor();
  void SetCachedSize(int size) const final;
  void InternalSwap(EventDataMetaData* other);
  private:
  inline ::google::protobuf::Arena* GetArenaNoVirtual() const {
    return nullptr;
  }
  inline void* MaybeArenaPtr() const {
    return nullptr;
  }
  public:

  ::google::protobuf::Metadata GetMetadata() const final;

  // nested types ----------------------------------------------------

  // accessors -------------------------------------------------------

  // string i18nDatabaseName = 1;
  void clear_i18ndatabasename();
  static const int kI18NDatabaseNameFieldNumber = 1;
  const ::std::string& i18ndatabasename() const;
  void set_i18ndatabasename(const ::std::string& value);
  #if LANG_CXX11
  void set_i18ndatabasename(::std::string&& value);
  #endif
  void set_i18ndatabasename(const char* value);
  void set_i18ndatabasename(const char* value, size_t size);
  ::std::string* mutable_i18ndatabasename();
  ::std::string* release_i18ndatabasename();
  void set_allocated_i18ndatabasename(::std::string* i18ndatabasename);

  // string i18nKey = 3;
  void clear_i18nkey();
  static const int kI18NKeyFieldNumber = 3;
  const ::std::string& i18nkey() const;
  void set_i18nkey(const ::std::string& value);
  #if LANG_CXX11
  void set_i18nkey(::std::string&& value);
  #endif
  void set_i18nkey(const char* value);
  void set_i18nkey(const char* value, size_t size);
  ::std::string* mutable_i18nkey();
  ::std::string* release_i18nkey();
  void set_allocated_i18nkey(::std::string* i18nkey);

  // int32 translationIndex = 2;
  void clear_translationindex();
  static const int kTranslationIndexFieldNumber = 2;
  ::google::protobuf::int32 translationindex() const;
  void set_translationindex(::google::protobuf::int32 value);

  // int32 status = 4;
  void clear_status();
  static const int kStatusFieldNumber = 4;
  ::google::protobuf::int32 status() const;
  void set_status(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:claros.instrument.event.EventDataMetaData)
 private:
  class HasBitSetters;

  ::google::protobuf::internal::InternalMetadataWithArena _internal_metadata_;
  ::google::protobuf::internal::ArenaStringPtr i18ndatabasename_;
  ::google::protobuf::internal::ArenaStringPtr i18nkey_;
  ::google::protobuf::int32 translationindex_;
  ::google::protobuf::int32 status_;
  mutable ::google::protobuf::internal::CachedSize _cached_size_;
  friend struct ::TableStruct_claros_5finstrument_5fevent_5fdata_5fmetadata_2eproto;
};
// ===================================================================


// ===================================================================

#ifdef __GNUC__
  #pragma GCC diagnostic push
  #pragma GCC diagnostic ignored "-Wstrict-aliasing"
#endif  // __GNUC__
// EventDataMetaData

// string i18nDatabaseName = 1;
inline void EventDataMetaData::clear_i18ndatabasename() {
  i18ndatabasename_.ClearToEmptyNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline const ::std::string& EventDataMetaData::i18ndatabasename() const {
  // @@protoc_insertion_point(field_get:claros.instrument.event.EventDataMetaData.i18nDatabaseName)
  return i18ndatabasename_.GetNoArena();
}
inline void EventDataMetaData::set_i18ndatabasename(const ::std::string& value) {
  
  i18ndatabasename_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), value);
  // @@protoc_insertion_point(field_set:claros.instrument.event.EventDataMetaData.i18nDatabaseName)
}
#if LANG_CXX11
inline void EventDataMetaData::set_i18ndatabasename(::std::string&& value) {
  
  i18ndatabasename_.SetNoArena(
    &::google::protobuf::internal::GetEmptyStringAlreadyInited(), ::std::move(value));
  // @@protoc_insertion_point(field_set_rvalue:claros.instrument.event.EventDataMetaData.i18nDatabaseName)
}
#endif
inline void EventDataMetaData::set_i18ndatabasename(const char* value) {
  GOOGLE_DCHECK(value != nullptr);
  
  i18ndatabasename_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), ::std::string(value));
  // @@protoc_insertion_point(field_set_char:claros.instrument.event.EventDataMetaData.i18nDatabaseName)
}
inline void EventDataMetaData::set_i18ndatabasename(const char* value, size_t size) {
  
  i18ndatabasename_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(),
      ::std::string(reinterpret_cast<const char*>(value), size));
  // @@protoc_insertion_point(field_set_pointer:claros.instrument.event.EventDataMetaData.i18nDatabaseName)
}
inline ::std::string* EventDataMetaData::mutable_i18ndatabasename() {
  
  // @@protoc_insertion_point(field_mutable:claros.instrument.event.EventDataMetaData.i18nDatabaseName)
  return i18ndatabasename_.MutableNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline ::std::string* EventDataMetaData::release_i18ndatabasename() {
  // @@protoc_insertion_point(field_release:claros.instrument.event.EventDataMetaData.i18nDatabaseName)
  
  return i18ndatabasename_.ReleaseNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline void EventDataMetaData::set_allocated_i18ndatabasename(::std::string* i18ndatabasename) {
  if (i18ndatabasename != nullptr) {
    
  } else {
    
  }
  i18ndatabasename_.SetAllocatedNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), i18ndatabasename);
  // @@protoc_insertion_point(field_set_allocated:claros.instrument.event.EventDataMetaData.i18nDatabaseName)
}

// int32 translationIndex = 2;
inline void EventDataMetaData::clear_translationindex() {
  translationindex_ = 0;
}
inline ::google::protobuf::int32 EventDataMetaData::translationindex() const {
  // @@protoc_insertion_point(field_get:claros.instrument.event.EventDataMetaData.translationIndex)
  return translationindex_;
}
inline void EventDataMetaData::set_translationindex(::google::protobuf::int32 value) {
  
  translationindex_ = value;
  // @@protoc_insertion_point(field_set:claros.instrument.event.EventDataMetaData.translationIndex)
}

// string i18nKey = 3;
inline void EventDataMetaData::clear_i18nkey() {
  i18nkey_.ClearToEmptyNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline const ::std::string& EventDataMetaData::i18nkey() const {
  // @@protoc_insertion_point(field_get:claros.instrument.event.EventDataMetaData.i18nKey)
  return i18nkey_.GetNoArena();
}
inline void EventDataMetaData::set_i18nkey(const ::std::string& value) {
  
  i18nkey_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), value);
  // @@protoc_insertion_point(field_set:claros.instrument.event.EventDataMetaData.i18nKey)
}
#if LANG_CXX11
inline void EventDataMetaData::set_i18nkey(::std::string&& value) {
  
  i18nkey_.SetNoArena(
    &::google::protobuf::internal::GetEmptyStringAlreadyInited(), ::std::move(value));
  // @@protoc_insertion_point(field_set_rvalue:claros.instrument.event.EventDataMetaData.i18nKey)
}
#endif
inline void EventDataMetaData::set_i18nkey(const char* value) {
  GOOGLE_DCHECK(value != nullptr);
  
  i18nkey_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), ::std::string(value));
  // @@protoc_insertion_point(field_set_char:claros.instrument.event.EventDataMetaData.i18nKey)
}
inline void EventDataMetaData::set_i18nkey(const char* value, size_t size) {
  
  i18nkey_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(),
      ::std::string(reinterpret_cast<const char*>(value), size));
  // @@protoc_insertion_point(field_set_pointer:claros.instrument.event.EventDataMetaData.i18nKey)
}
inline ::std::string* EventDataMetaData::mutable_i18nkey() {
  
  // @@protoc_insertion_point(field_mutable:claros.instrument.event.EventDataMetaData.i18nKey)
  return i18nkey_.MutableNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline ::std::string* EventDataMetaData::release_i18nkey() {
  // @@protoc_insertion_point(field_release:claros.instrument.event.EventDataMetaData.i18nKey)
  
  return i18nkey_.ReleaseNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline void EventDataMetaData::set_allocated_i18nkey(::std::string* i18nkey) {
  if (i18nkey != nullptr) {
    
  } else {
    
  }
  i18nkey_.SetAllocatedNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), i18nkey);
  // @@protoc_insertion_point(field_set_allocated:claros.instrument.event.EventDataMetaData.i18nKey)
}

// int32 status = 4;
inline void EventDataMetaData::clear_status() {
  status_ = 0;
}
inline ::google::protobuf::int32 EventDataMetaData::status() const {
  // @@protoc_insertion_point(field_get:claros.instrument.event.EventDataMetaData.status)
  return status_;
}
inline void EventDataMetaData::set_status(::google::protobuf::int32 value) {
  
  status_ = value;
  // @@protoc_insertion_point(field_set:claros.instrument.event.EventDataMetaData.status)
}

#ifdef __GNUC__
  #pragma GCC diagnostic pop
#endif  // __GNUC__

// @@protoc_insertion_point(namespace_scope)

}  // namespace event
}  // namespace instrument
}  // namespace claros

// @@protoc_insertion_point(global_scope)

#include <google/protobuf/port_undef.inc>
#endif  // PROTOBUF_INCLUDED_claros_5finstrument_5fevent_5fdata_5fmetadata_2eproto
