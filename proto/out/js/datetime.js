/**
 * @fileoverview
 * @enhanceable
 * @suppress {messageConventions} JS Compiler reports an error if a variable or
 *     field starts with 'MSG_' and isn't a translatable message.
 * @public
 */
// GENERATED CODE -- DO NOT EDIT!

goog.provide('proto.claros.common.DateTime');
goog.provide('proto.claros.common.DateTime.Date');
goog.provide('proto.claros.common.DateTime.Time');

goog.require('jspb.BinaryReader');
goog.require('jspb.BinaryWriter');
goog.require('jspb.Message');

/**
 * Generated by JsPbCodeGenerator.
 * @param {Array=} opt_data Optional initial data array, typically from a
 * server response, or constructed directly in Javascript. The array is used
 * in place and becomes part of the constructed object. It is not cloned.
 * If no data is provided, the constructed object will be empty, but still
 * valid.
 * @extends {jspb.Message}
 * @constructor
 */
proto.claros.common.DateTime = function(opt_data) {
  jspb.Message.initialize(this, opt_data, 0, -1, null, null);
};
goog.inherits(proto.claros.common.DateTime, jspb.Message);
if (goog.DEBUG && !COMPILED) {
  /**
   * @public
   * @override
   */
  proto.claros.common.DateTime.displayName = 'proto.claros.common.DateTime';
}
/**
 * Generated by JsPbCodeGenerator.
 * @param {Array=} opt_data Optional initial data array, typically from a
 * server response, or constructed directly in Javascript. The array is used
 * in place and becomes part of the constructed object. It is not cloned.
 * If no data is provided, the constructed object will be empty, but still
 * valid.
 * @extends {jspb.Message}
 * @constructor
 */
proto.claros.common.DateTime.Time = function(opt_data) {
  jspb.Message.initialize(this, opt_data, 0, -1, null, null);
};
goog.inherits(proto.claros.common.DateTime.Time, jspb.Message);
if (goog.DEBUG && !COMPILED) {
  /**
   * @public
   * @override
   */
  proto.claros.common.DateTime.Time.displayName = 'proto.claros.common.DateTime.Time';
}
/**
 * Generated by JsPbCodeGenerator.
 * @param {Array=} opt_data Optional initial data array, typically from a
 * server response, or constructed directly in Javascript. The array is used
 * in place and becomes part of the constructed object. It is not cloned.
 * If no data is provided, the constructed object will be empty, but still
 * valid.
 * @extends {jspb.Message}
 * @constructor
 */
proto.claros.common.DateTime.Date = function(opt_data) {
  jspb.Message.initialize(this, opt_data, 0, -1, null, null);
};
goog.inherits(proto.claros.common.DateTime.Date, jspb.Message);
if (goog.DEBUG && !COMPILED) {
  /**
   * @public
   * @override
   */
  proto.claros.common.DateTime.Date.displayName = 'proto.claros.common.DateTime.Date';
}



if (jspb.Message.GENERATE_TO_OBJECT) {
/**
 * Creates an object representation of this proto suitable for use in Soy templates.
 * Field names that are reserved in JavaScript and will be renamed to pb_name.
 * To access a reserved field use, foo.pb_<name>, eg, foo.pb_default.
 * For the list of reserved names please see:
 *     com.google.apps.jspb.JsClassTemplate.JS_RESERVED_WORDS.
 * @param {boolean=} opt_includeInstance Whether to include the JSPB instance
 *     for transitional soy proto support: http://goto/soy-param-migration
 * @return {!Object}
 */
proto.claros.common.DateTime.prototype.toObject = function(opt_includeInstance) {
  return proto.claros.common.DateTime.toObject(opt_includeInstance, this);
};


/**
 * Static version of the {@see toObject} method.
 * @param {boolean|undefined} includeInstance Whether to include the JSPB
 *     instance for transitional soy proto support:
 *     http://goto/soy-param-migration
 * @param {!proto.claros.common.DateTime} msg The msg instance to transform.
 * @return {!Object}
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.claros.common.DateTime.toObject = function(includeInstance, msg) {
  var f, obj = {
    datefield: (f = msg.getDatefield()) && proto.claros.common.DateTime.Date.toObject(includeInstance, f),
    timefield: (f = msg.getTimefield()) && proto.claros.common.DateTime.Time.toObject(includeInstance, f),
    timezone: jspb.Message.getFieldWithDefault(msg, 3, 0)
  };

  if (includeInstance) {
    obj.$jspbMessageInstance = msg;
  }
  return obj;
};
}


/**
 * Deserializes binary data (in protobuf wire format).
 * @param {jspb.ByteSource} bytes The bytes to deserialize.
 * @return {!proto.claros.common.DateTime}
 */
proto.claros.common.DateTime.deserializeBinary = function(bytes) {
  var reader = new jspb.BinaryReader(bytes);
  var msg = new proto.claros.common.DateTime;
  return proto.claros.common.DateTime.deserializeBinaryFromReader(msg, reader);
};


/**
 * Deserializes binary data (in protobuf wire format) from the
 * given reader into the given message object.
 * @param {!proto.claros.common.DateTime} msg The message object to deserialize into.
 * @param {!jspb.BinaryReader} reader The BinaryReader to use.
 * @return {!proto.claros.common.DateTime}
 */
proto.claros.common.DateTime.deserializeBinaryFromReader = function(msg, reader) {
  while (reader.nextField()) {
    if (reader.isEndGroup()) {
      break;
    }
    var field = reader.getFieldNumber();
    switch (field) {
    case 1:
      var value = new proto.claros.common.DateTime.Date;
      reader.readMessage(value,proto.claros.common.DateTime.Date.deserializeBinaryFromReader);
      msg.setDatefield(value);
      break;
    case 2:
      var value = new proto.claros.common.DateTime.Time;
      reader.readMessage(value,proto.claros.common.DateTime.Time.deserializeBinaryFromReader);
      msg.setTimefield(value);
      break;
    case 3:
      var value = /** @type {number} */ (reader.readInt32());
      msg.setTimezone(value);
      break;
    default:
      reader.skipField();
      break;
    }
  }
  return msg;
};


/**
 * Serializes the message to binary data (in protobuf wire format).
 * @return {!Uint8Array}
 */
proto.claros.common.DateTime.prototype.serializeBinary = function() {
  var writer = new jspb.BinaryWriter();
  proto.claros.common.DateTime.serializeBinaryToWriter(this, writer);
  return writer.getResultBuffer();
};


/**
 * Serializes the given message to binary data (in protobuf wire
 * format), writing to the given BinaryWriter.
 * @param {!proto.claros.common.DateTime} message
 * @param {!jspb.BinaryWriter} writer
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.claros.common.DateTime.serializeBinaryToWriter = function(message, writer) {
  var f = undefined;
  f = message.getDatefield();
  if (f != null) {
    writer.writeMessage(
      1,
      f,
      proto.claros.common.DateTime.Date.serializeBinaryToWriter
    );
  }
  f = message.getTimefield();
  if (f != null) {
    writer.writeMessage(
      2,
      f,
      proto.claros.common.DateTime.Time.serializeBinaryToWriter
    );
  }
  f = message.getTimezone();
  if (f !== 0) {
    writer.writeInt32(
      3,
      f
    );
  }
};





if (jspb.Message.GENERATE_TO_OBJECT) {
/**
 * Creates an object representation of this proto suitable for use in Soy templates.
 * Field names that are reserved in JavaScript and will be renamed to pb_name.
 * To access a reserved field use, foo.pb_<name>, eg, foo.pb_default.
 * For the list of reserved names please see:
 *     com.google.apps.jspb.JsClassTemplate.JS_RESERVED_WORDS.
 * @param {boolean=} opt_includeInstance Whether to include the JSPB instance
 *     for transitional soy proto support: http://goto/soy-param-migration
 * @return {!Object}
 */
proto.claros.common.DateTime.Time.prototype.toObject = function(opt_includeInstance) {
  return proto.claros.common.DateTime.Time.toObject(opt_includeInstance, this);
};


/**
 * Static version of the {@see toObject} method.
 * @param {boolean|undefined} includeInstance Whether to include the JSPB
 *     instance for transitional soy proto support:
 *     http://goto/soy-param-migration
 * @param {!proto.claros.common.DateTime.Time} msg The msg instance to transform.
 * @return {!Object}
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.claros.common.DateTime.Time.toObject = function(includeInstance, msg) {
  var f, obj = {
    hours: jspb.Message.getFieldWithDefault(msg, 1, 0),
    minutes: jspb.Message.getFieldWithDefault(msg, 2, 0),
    seconds: jspb.Message.getFieldWithDefault(msg, 3, 0)
  };

  if (includeInstance) {
    obj.$jspbMessageInstance = msg;
  }
  return obj;
};
}


/**
 * Deserializes binary data (in protobuf wire format).
 * @param {jspb.ByteSource} bytes The bytes to deserialize.
 * @return {!proto.claros.common.DateTime.Time}
 */
proto.claros.common.DateTime.Time.deserializeBinary = function(bytes) {
  var reader = new jspb.BinaryReader(bytes);
  var msg = new proto.claros.common.DateTime.Time;
  return proto.claros.common.DateTime.Time.deserializeBinaryFromReader(msg, reader);
};


/**
 * Deserializes binary data (in protobuf wire format) from the
 * given reader into the given message object.
 * @param {!proto.claros.common.DateTime.Time} msg The message object to deserialize into.
 * @param {!jspb.BinaryReader} reader The BinaryReader to use.
 * @return {!proto.claros.common.DateTime.Time}
 */
proto.claros.common.DateTime.Time.deserializeBinaryFromReader = function(msg, reader) {
  while (reader.nextField()) {
    if (reader.isEndGroup()) {
      break;
    }
    var field = reader.getFieldNumber();
    switch (field) {
    case 1:
      var value = /** @type {number} */ (reader.readUint32());
      msg.setHours(value);
      break;
    case 2:
      var value = /** @type {number} */ (reader.readUint32());
      msg.setMinutes(value);
      break;
    case 3:
      var value = /** @type {number} */ (reader.readUint32());
      msg.setSeconds(value);
      break;
    default:
      reader.skipField();
      break;
    }
  }
  return msg;
};


/**
 * Serializes the message to binary data (in protobuf wire format).
 * @return {!Uint8Array}
 */
proto.claros.common.DateTime.Time.prototype.serializeBinary = function() {
  var writer = new jspb.BinaryWriter();
  proto.claros.common.DateTime.Time.serializeBinaryToWriter(this, writer);
  return writer.getResultBuffer();
};


/**
 * Serializes the given message to binary data (in protobuf wire
 * format), writing to the given BinaryWriter.
 * @param {!proto.claros.common.DateTime.Time} message
 * @param {!jspb.BinaryWriter} writer
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.claros.common.DateTime.Time.serializeBinaryToWriter = function(message, writer) {
  var f = undefined;
  f = message.getHours();
  if (f !== 0) {
    writer.writeUint32(
      1,
      f
    );
  }
  f = message.getMinutes();
  if (f !== 0) {
    writer.writeUint32(
      2,
      f
    );
  }
  f = message.getSeconds();
  if (f !== 0) {
    writer.writeUint32(
      3,
      f
    );
  }
};


/**
 * optional uint32 hours = 1;
 * @return {number}
 */
proto.claros.common.DateTime.Time.prototype.getHours = function() {
  return /** @type {number} */ (jspb.Message.getFieldWithDefault(this, 1, 0));
};


/** @param {number} value */
proto.claros.common.DateTime.Time.prototype.setHours = function(value) {
  jspb.Message.setProto3IntField(this, 1, value);
};


/**
 * optional uint32 minutes = 2;
 * @return {number}
 */
proto.claros.common.DateTime.Time.prototype.getMinutes = function() {
  return /** @type {number} */ (jspb.Message.getFieldWithDefault(this, 2, 0));
};


/** @param {number} value */
proto.claros.common.DateTime.Time.prototype.setMinutes = function(value) {
  jspb.Message.setProto3IntField(this, 2, value);
};


/**
 * optional uint32 seconds = 3;
 * @return {number}
 */
proto.claros.common.DateTime.Time.prototype.getSeconds = function() {
  return /** @type {number} */ (jspb.Message.getFieldWithDefault(this, 3, 0));
};


/** @param {number} value */
proto.claros.common.DateTime.Time.prototype.setSeconds = function(value) {
  jspb.Message.setProto3IntField(this, 3, value);
};





if (jspb.Message.GENERATE_TO_OBJECT) {
/**
 * Creates an object representation of this proto suitable for use in Soy templates.
 * Field names that are reserved in JavaScript and will be renamed to pb_name.
 * To access a reserved field use, foo.pb_<name>, eg, foo.pb_default.
 * For the list of reserved names please see:
 *     com.google.apps.jspb.JsClassTemplate.JS_RESERVED_WORDS.
 * @param {boolean=} opt_includeInstance Whether to include the JSPB instance
 *     for transitional soy proto support: http://goto/soy-param-migration
 * @return {!Object}
 */
proto.claros.common.DateTime.Date.prototype.toObject = function(opt_includeInstance) {
  return proto.claros.common.DateTime.Date.toObject(opt_includeInstance, this);
};


/**
 * Static version of the {@see toObject} method.
 * @param {boolean|undefined} includeInstance Whether to include the JSPB
 *     instance for transitional soy proto support:
 *     http://goto/soy-param-migration
 * @param {!proto.claros.common.DateTime.Date} msg The msg instance to transform.
 * @return {!Object}
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.claros.common.DateTime.Date.toObject = function(includeInstance, msg) {
  var f, obj = {
    year: jspb.Message.getFieldWithDefault(msg, 1, 0),
    month: jspb.Message.getFieldWithDefault(msg, 2, 0),
    day: jspb.Message.getFieldWithDefault(msg, 3, 0)
  };

  if (includeInstance) {
    obj.$jspbMessageInstance = msg;
  }
  return obj;
};
}


/**
 * Deserializes binary data (in protobuf wire format).
 * @param {jspb.ByteSource} bytes The bytes to deserialize.
 * @return {!proto.claros.common.DateTime.Date}
 */
proto.claros.common.DateTime.Date.deserializeBinary = function(bytes) {
  var reader = new jspb.BinaryReader(bytes);
  var msg = new proto.claros.common.DateTime.Date;
  return proto.claros.common.DateTime.Date.deserializeBinaryFromReader(msg, reader);
};


/**
 * Deserializes binary data (in protobuf wire format) from the
 * given reader into the given message object.
 * @param {!proto.claros.common.DateTime.Date} msg The message object to deserialize into.
 * @param {!jspb.BinaryReader} reader The BinaryReader to use.
 * @return {!proto.claros.common.DateTime.Date}
 */
proto.claros.common.DateTime.Date.deserializeBinaryFromReader = function(msg, reader) {
  while (reader.nextField()) {
    if (reader.isEndGroup()) {
      break;
    }
    var field = reader.getFieldNumber();
    switch (field) {
    case 1:
      var value = /** @type {number} */ (reader.readUint32());
      msg.setYear(value);
      break;
    case 2:
      var value = /** @type {number} */ (reader.readUint32());
      msg.setMonth(value);
      break;
    case 3:
      var value = /** @type {number} */ (reader.readUint32());
      msg.setDay(value);
      break;
    default:
      reader.skipField();
      break;
    }
  }
  return msg;
};


/**
 * Serializes the message to binary data (in protobuf wire format).
 * @return {!Uint8Array}
 */
proto.claros.common.DateTime.Date.prototype.serializeBinary = function() {
  var writer = new jspb.BinaryWriter();
  proto.claros.common.DateTime.Date.serializeBinaryToWriter(this, writer);
  return writer.getResultBuffer();
};


/**
 * Serializes the given message to binary data (in protobuf wire
 * format), writing to the given BinaryWriter.
 * @param {!proto.claros.common.DateTime.Date} message
 * @param {!jspb.BinaryWriter} writer
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.claros.common.DateTime.Date.serializeBinaryToWriter = function(message, writer) {
  var f = undefined;
  f = message.getYear();
  if (f !== 0) {
    writer.writeUint32(
      1,
      f
    );
  }
  f = message.getMonth();
  if (f !== 0) {
    writer.writeUint32(
      2,
      f
    );
  }
  f = message.getDay();
  if (f !== 0) {
    writer.writeUint32(
      3,
      f
    );
  }
};


/**
 * optional uint32 year = 1;
 * @return {number}
 */
proto.claros.common.DateTime.Date.prototype.getYear = function() {
  return /** @type {number} */ (jspb.Message.getFieldWithDefault(this, 1, 0));
};


/** @param {number} value */
proto.claros.common.DateTime.Date.prototype.setYear = function(value) {
  jspb.Message.setProto3IntField(this, 1, value);
};


/**
 * optional uint32 month = 2;
 * @return {number}
 */
proto.claros.common.DateTime.Date.prototype.getMonth = function() {
  return /** @type {number} */ (jspb.Message.getFieldWithDefault(this, 2, 0));
};


/** @param {number} value */
proto.claros.common.DateTime.Date.prototype.setMonth = function(value) {
  jspb.Message.setProto3IntField(this, 2, value);
};


/**
 * optional uint32 day = 3;
 * @return {number}
 */
proto.claros.common.DateTime.Date.prototype.getDay = function() {
  return /** @type {number} */ (jspb.Message.getFieldWithDefault(this, 3, 0));
};


/** @param {number} value */
proto.claros.common.DateTime.Date.prototype.setDay = function(value) {
  jspb.Message.setProto3IntField(this, 3, value);
};


/**
 * optional Date dateField = 1;
 * @return {?proto.claros.common.DateTime.Date}
 */
proto.claros.common.DateTime.prototype.getDatefield = function() {
  return /** @type{?proto.claros.common.DateTime.Date} */ (
    jspb.Message.getWrapperField(this, proto.claros.common.DateTime.Date, 1));
};


/** @param {?proto.claros.common.DateTime.Date|undefined} value */
proto.claros.common.DateTime.prototype.setDatefield = function(value) {
  jspb.Message.setWrapperField(this, 1, value);
};


/**
 * Clears the message field making it undefined.
 */
proto.claros.common.DateTime.prototype.clearDatefield = function() {
  this.setDatefield(undefined);
};


/**
 * Returns whether this field is set.
 * @return {boolean}
 */
proto.claros.common.DateTime.prototype.hasDatefield = function() {
  return jspb.Message.getField(this, 1) != null;
};


/**
 * optional Time timeField = 2;
 * @return {?proto.claros.common.DateTime.Time}
 */
proto.claros.common.DateTime.prototype.getTimefield = function() {
  return /** @type{?proto.claros.common.DateTime.Time} */ (
    jspb.Message.getWrapperField(this, proto.claros.common.DateTime.Time, 2));
};


/** @param {?proto.claros.common.DateTime.Time|undefined} value */
proto.claros.common.DateTime.prototype.setTimefield = function(value) {
  jspb.Message.setWrapperField(this, 2, value);
};


/**
 * Clears the message field making it undefined.
 */
proto.claros.common.DateTime.prototype.clearTimefield = function() {
  this.setTimefield(undefined);
};


/**
 * Returns whether this field is set.
 * @return {boolean}
 */
proto.claros.common.DateTime.prototype.hasTimefield = function() {
  return jspb.Message.getField(this, 2) != null;
};


/**
 * optional int32 timeZone = 3;
 * @return {number}
 */
proto.claros.common.DateTime.prototype.getTimezone = function() {
  return /** @type {number} */ (jspb.Message.getFieldWithDefault(this, 3, 0));
};


/** @param {number} value */
proto.claros.common.DateTime.prototype.setTimezone = function(value) {
  jspb.Message.setProto3IntField(this, 3, value);
};


