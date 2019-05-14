<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: claros_instrument_setting_data.proto

namespace Claros\Instrument;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Generated from protobuf message <code>claros.instrument.Setting</code>
 */
class Setting extends \Google\Protobuf\Internal\Message
{
    /**
     * Generated from protobuf field <code>map<string, string> settings = 1;</code>
     */
    private $settings;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type array|\Google\Protobuf\Internal\MapField $settings
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\ClarosInstrumentSettingData::initOnce();
        parent::__construct($data);
    }

    /**
     * Generated from protobuf field <code>map<string, string> settings = 1;</code>
     * @return \Google\Protobuf\Internal\MapField
     */
    public function getSettings()
    {
        return $this->settings;
    }

    /**
     * Generated from protobuf field <code>map<string, string> settings = 1;</code>
     * @param array|\Google\Protobuf\Internal\MapField $var
     * @return $this
     */
    public function setSettings($var)
    {
        $arr = GPBUtil::checkMapField($var, \Google\Protobuf\Internal\GPBType::STRING, \Google\Protobuf\Internal\GPBType::STRING);
        $this->settings = $arr;

        return $this;
    }

}

