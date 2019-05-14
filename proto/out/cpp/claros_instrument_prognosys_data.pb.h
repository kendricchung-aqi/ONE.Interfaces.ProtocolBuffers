// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: claros_instrument_prognosys_data.proto

#ifndef PROTOBUF_INCLUDED_claros_5finstrument_5fprognosys_5fdata_2eproto
#define PROTOBUF_INCLUDED_claros_5finstrument_5fprognosys_5fdata_2eproto

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
#define PROTOBUF_INTERNAL_EXPORT_claros_5finstrument_5fprognosys_5fdata_2eproto

// Internal implementation detail -- do not use these members.
struct TableStruct_claros_5finstrument_5fprognosys_5fdata_2eproto {
  static const ::google::protobuf::internal::ParseTableField entries[]
    PROTOBUF_SECTION_VARIABLE(protodesc_cold);
  static const ::google::protobuf::internal::AuxillaryParseTableField aux[]
    PROTOBUF_SECTION_VARIABLE(protodesc_cold);
  static const ::google::protobuf::internal::ParseTable schema[2]
    PROTOBUF_SECTION_VARIABLE(protodesc_cold);
  static const ::google::protobuf::internal::FieldMetadata field_metadata[];
  static const ::google::protobuf::internal::SerializationTable serialization_table[];
  static const ::google::protobuf::uint32 offsets[];
};
void AddDescriptors_claros_5finstrument_5fprognosys_5fdata_2eproto();
namespace claros {
namespace instrument {
class PrognosysData;
class PrognosysDataDefaultTypeInternal;
extern PrognosysDataDefaultTypeInternal _PrognosysData_default_instance_;
class PrognosysData_Prognosys;
class PrognosysData_PrognosysDefaultTypeInternal;
extern PrognosysData_PrognosysDefaultTypeInternal _PrognosysData_Prognosys_default_instance_;
}  // namespace instrument
}  // namespace claros
namespace google {
namespace protobuf {
template<> ::claros::instrument::PrognosysData* Arena::CreateMaybeMessage<::claros::instrument::PrognosysData>(Arena*);
template<> ::claros::instrument::PrognosysData_Prognosys* Arena::CreateMaybeMessage<::claros::instrument::PrognosysData_Prognosys>(Arena*);
}  // namespace protobuf
}  // namespace google
namespace claros {
namespace instrument {

// ===================================================================

class PrognosysData_Prognosys :
    public ::google::protobuf::Message /* @@protoc_insertion_point(class_definition:claros.instrument.PrognosysData.Prognosys) */ {
 public:
  PrognosysData_Prognosys();
  virtual ~PrognosysData_Prognosys();

  PrognosysData_Prognosys(const PrognosysData_Prognosys& from);

  inline PrognosysData_Prognosys& operator=(const PrognosysData_Prognosys& from) {
    CopyFrom(from);
    return *this;
  }
  #if LANG_CXX11
  PrognosysData_Prognosys(PrognosysData_Prognosys&& from) noexcept
    : PrognosysData_Prognosys() {
    *this = ::std::move(from);
  }

  inline PrognosysData_Prognosys& operator=(PrognosysData_Prognosys&& from) noexcept {
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
  static const PrognosysData_Prognosys& default_instance();

  static void InitAsDefaultInstance();  // FOR INTERNAL USE ONLY
  static inline const PrognosysData_Prognosys* internal_default_instance() {
    return reinterpret_cast<const PrognosysData_Prognosys*>(
               &_PrognosysData_Prognosys_default_instance_);
  }
  static constexpr int kIndexInFileMessages =
    0;

  void Swap(PrognosysData_Prognosys* other);
  friend void swap(PrognosysData_Prognosys& a, PrognosysData_Prognosys& b) {
    a.Swap(&b);
  }

  // implements Message ----------------------------------------------

  inline PrognosysData_Prognosys* New() const final {
    return CreateMaybeMessage<PrognosysData_Prognosys>(nullptr);
  }

  PrognosysData_Prognosys* New(::google::protobuf::Arena* arena) const final {
    return CreateMaybeMessage<PrognosysData_Prognosys>(arena);
  }
  void CopyFrom(const ::google::protobuf::Message& from) final;
  void MergeFrom(const ::google::protobuf::Message& from) final;
  void CopyFrom(const PrognosysData_Prognosys& from);
  void MergeFrom(const PrognosysData_Prognosys& from);
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
  void InternalSwap(PrognosysData_Prognosys* other);
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

  // int32 id = 1;
  void clear_id();
  static const int kIdFieldNumber = 1;
  ::google::protobuf::int32 id() const;
  void set_id(::google::protobuf::int32 value);

  // float percent = 2;
  void clear_percent();
  static const int kPercentFieldNumber = 2;
  float percent() const;
  void set_percent(float value);

  // int32 days = 3;
  void clear_days();
  static const int kDaysFieldNumber = 3;
  ::google::protobuf::int32 days() const;
  void set_days(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:claros.instrument.PrognosysData.Prognosys)
 private:
  class HasBitSetters;

  ::google::protobuf::internal::InternalMetadataWithArena _internal_metadata_;
  ::google::protobuf::int32 id_;
  float percent_;
  ::google::protobuf::int32 days_;
  mutable ::google::protobuf::internal::CachedSize _cached_size_;
  friend struct ::TableStruct_claros_5finstrument_5fprognosys_5fdata_2eproto;
};
// -------------------------------------------------------------------

class PrognosysData :
    public ::google::protobuf::Message /* @@protoc_insertion_point(class_definition:claros.instrument.PrognosysData) */ {
 public:
  PrognosysData();
  virtual ~PrognosysData();

  PrognosysData(const PrognosysData& from);

  inline PrognosysData& operator=(const PrognosysData& from) {
    CopyFrom(from);
    return *this;
  }
  #if LANG_CXX11
  PrognosysData(PrognosysData&& from) noexcept
    : PrognosysData() {
    *this = ::std::move(from);
  }

  inline PrognosysData& operator=(PrognosysData&& from) noexcept {
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
  static const PrognosysData& default_instance();

  static void InitAsDefaultInstance();  // FOR INTERNAL USE ONLY
  static inline const PrognosysData* internal_default_instance() {
    return reinterpret_cast<const PrognosysData*>(
               &_PrognosysData_default_instance_);
  }
  static constexpr int kIndexInFileMessages =
    1;

  void Swap(PrognosysData* other);
  friend void swap(PrognosysData& a, PrognosysData& b) {
    a.Swap(&b);
  }

  // implements Message ----------------------------------------------

  inline PrognosysData* New() const final {
    return CreateMaybeMessage<PrognosysData>(nullptr);
  }

  PrognosysData* New(::google::protobuf::Arena* arena) const final {
    return CreateMaybeMessage<PrognosysData>(arena);
  }
  void CopyFrom(const ::google::protobuf::Message& from) final;
  void MergeFrom(const ::google::protobuf::Message& from) final;
  void CopyFrom(const PrognosysData& from);
  void MergeFrom(const PrognosysData& from);
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
  void InternalSwap(PrognosysData* other);
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

  typedef PrognosysData_Prognosys Prognosys;

  // accessors -------------------------------------------------------

  // repeated .claros.instrument.PrognosysData.Prognosys prognoses = 1;
  int prognoses_size() const;
  void clear_prognoses();
  static const int kPrognosesFieldNumber = 1;
  ::claros::instrument::PrognosysData_Prognosys* mutable_prognoses(int index);
  ::google::protobuf::RepeatedPtrField< ::claros::instrument::PrognosysData_Prognosys >*
      mutable_prognoses();
  const ::claros::instrument::PrognosysData_Prognosys& prognoses(int index) const;
  ::claros::instrument::PrognosysData_Prognosys* add_prognoses();
  const ::google::protobuf::RepeatedPtrField< ::claros::instrument::PrognosysData_Prognosys >&
      prognoses() const;

  // @@protoc_insertion_point(class_scope:claros.instrument.PrognosysData)
 private:
  class HasBitSetters;

  ::google::protobuf::internal::InternalMetadataWithArena _internal_metadata_;
  ::google::protobuf::RepeatedPtrField< ::claros::instrument::PrognosysData_Prognosys > prognoses_;
  mutable ::google::protobuf::internal::CachedSize _cached_size_;
  friend struct ::TableStruct_claros_5finstrument_5fprognosys_5fdata_2eproto;
};
// ===================================================================


// ===================================================================

#ifdef __GNUC__
  #pragma GCC diagnostic push
  #pragma GCC diagnostic ignored "-Wstrict-aliasing"
#endif  // __GNUC__
// PrognosysData_Prognosys

// int32 id = 1;
inline void PrognosysData_Prognosys::clear_id() {
  id_ = 0;
}
inline ::google::protobuf::int32 PrognosysData_Prognosys::id() const {
  // @@protoc_insertion_point(field_get:claros.instrument.PrognosysData.Prognosys.id)
  return id_;
}
inline void PrognosysData_Prognosys::set_id(::google::protobuf::int32 value) {
  
  id_ = value;
  // @@protoc_insertion_point(field_set:claros.instrument.PrognosysData.Prognosys.id)
}

// float percent = 2;
inline void PrognosysData_Prognosys::clear_percent() {
  percent_ = 0;
}
inline float PrognosysData_Prognosys::percent() const {
  // @@protoc_insertion_point(field_get:claros.instrument.PrognosysData.Prognosys.percent)
  return percent_;
}
inline void PrognosysData_Prognosys::set_percent(float value) {
  
  percent_ = value;
  // @@protoc_insertion_point(field_set:claros.instrument.PrognosysData.Prognosys.percent)
}

// int32 days = 3;
inline void PrognosysData_Prognosys::clear_days() {
  days_ = 0;
}
inline ::google::protobuf::int32 PrognosysData_Prognosys::days() const {
  // @@protoc_insertion_point(field_get:claros.instrument.PrognosysData.Prognosys.days)
  return days_;
}
inline void PrognosysData_Prognosys::set_days(::google::protobuf::int32 value) {
  
  days_ = value;
  // @@protoc_insertion_point(field_set:claros.instrument.PrognosysData.Prognosys.days)
}

// -------------------------------------------------------------------

// PrognosysData

// repeated .claros.instrument.PrognosysData.Prognosys prognoses = 1;
inline int PrognosysData::prognoses_size() const {
  return prognoses_.size();
}
inline void PrognosysData::clear_prognoses() {
  prognoses_.Clear();
}
inline ::claros::instrument::PrognosysData_Prognosys* PrognosysData::mutable_prognoses(int index) {
  // @@protoc_insertion_point(field_mutable:claros.instrument.PrognosysData.prognoses)
  return prognoses_.Mutable(index);
}
inline ::google::protobuf::RepeatedPtrField< ::claros::instrument::PrognosysData_Prognosys >*
PrognosysData::mutable_prognoses() {
  // @@protoc_insertion_point(field_mutable_list:claros.instrument.PrognosysData.prognoses)
  return &prognoses_;
}
inline const ::claros::instrument::PrognosysData_Prognosys& PrognosysData::prognoses(int index) const {
  // @@protoc_insertion_point(field_get:claros.instrument.PrognosysData.prognoses)
  return prognoses_.Get(index);
}
inline ::claros::instrument::PrognosysData_Prognosys* PrognosysData::add_prognoses() {
  // @@protoc_insertion_point(field_add:claros.instrument.PrognosysData.prognoses)
  return prognoses_.Add();
}
inline const ::google::protobuf::RepeatedPtrField< ::claros::instrument::PrognosysData_Prognosys >&
PrognosysData::prognoses() const {
  // @@protoc_insertion_point(field_list:claros.instrument.PrognosysData.prognoses)
  return prognoses_;
}

#ifdef __GNUC__
  #pragma GCC diagnostic pop
#endif  // __GNUC__
// -------------------------------------------------------------------


// @@protoc_insertion_point(namespace_scope)

}  // namespace instrument
}  // namespace claros

// @@protoc_insertion_point(global_scope)

#include <google/protobuf/port_undef.inc>
#endif  // PROTOBUF_INCLUDED_claros_5finstrument_5fprognosys_5fdata_2eproto
