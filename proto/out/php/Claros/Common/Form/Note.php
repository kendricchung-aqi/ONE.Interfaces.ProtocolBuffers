<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: claros_common_form_note.proto

namespace Claros\Common\Form;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Generated from protobuf message <code>claros.common.form.Note</code>
 */
class Note extends \Google\Protobuf\Internal\Message
{
    /**
     * Generated from protobuf field <code>string guid = 1;</code>
     */
    private $guid = '';
    /**
     * Generated from protobuf field <code>string formFieldGUID = 2;</code>
     */
    private $formFieldGUID = '';
    /**
     * Generated from protobuf field <code>string formGUID = 3;</code>
     */
    private $formGUID = '';
    /**
     * Generated from protobuf field <code>.claros.common.DateTime timeStamp = 4;</code>
     */
    private $timeStamp = null;
    /**
     * Generated from protobuf field <code>string userId = 5;</code>
     */
    private $userId = '';
    /**
     * Generated from protobuf field <code>string text = 6;</code>
     */
    private $text = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $guid
     *     @type string $formFieldGUID
     *     @type string $formGUID
     *     @type \Claros\Common\DateTime $timeStamp
     *     @type string $userId
     *     @type string $text
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\ClarosCommonFormNote::initOnce();
        parent::__construct($data);
    }

    /**
     * Generated from protobuf field <code>string guid = 1;</code>
     * @return string
     */
    public function getGuid()
    {
        return $this->guid;
    }

    /**
     * Generated from protobuf field <code>string guid = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setGuid($var)
    {
        GPBUtil::checkString($var, True);
        $this->guid = $var;

        return $this;
    }

    /**
     * Generated from protobuf field <code>string formFieldGUID = 2;</code>
     * @return string
     */
    public function getFormFieldGUID()
    {
        return $this->formFieldGUID;
    }

    /**
     * Generated from protobuf field <code>string formFieldGUID = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setFormFieldGUID($var)
    {
        GPBUtil::checkString($var, True);
        $this->formFieldGUID = $var;

        return $this;
    }

    /**
     * Generated from protobuf field <code>string formGUID = 3;</code>
     * @return string
     */
    public function getFormGUID()
    {
        return $this->formGUID;
    }

    /**
     * Generated from protobuf field <code>string formGUID = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setFormGUID($var)
    {
        GPBUtil::checkString($var, True);
        $this->formGUID = $var;

        return $this;
    }

    /**
     * Generated from protobuf field <code>.claros.common.DateTime timeStamp = 4;</code>
     * @return \Claros\Common\DateTime
     */
    public function getTimeStamp()
    {
        return $this->timeStamp;
    }

    /**
     * Generated from protobuf field <code>.claros.common.DateTime timeStamp = 4;</code>
     * @param \Claros\Common\DateTime $var
     * @return $this
     */
    public function setTimeStamp($var)
    {
        GPBUtil::checkMessage($var, \Claros\Common\DateTime::class);
        $this->timeStamp = $var;

        return $this;
    }

    /**
     * Generated from protobuf field <code>string userId = 5;</code>
     * @return string
     */
    public function getUserId()
    {
        return $this->userId;
    }

    /**
     * Generated from protobuf field <code>string userId = 5;</code>
     * @param string $var
     * @return $this
     */
    public function setUserId($var)
    {
        GPBUtil::checkString($var, True);
        $this->userId = $var;

        return $this;
    }

    /**
     * Generated from protobuf field <code>string text = 6;</code>
     * @return string
     */
    public function getText()
    {
        return $this->text;
    }

    /**
     * Generated from protobuf field <code>string text = 6;</code>
     * @param string $var
     * @return $this
     */
    public function setText($var)
    {
        GPBUtil::checkString($var, True);
        $this->text = $var;

        return $this;
    }

}

