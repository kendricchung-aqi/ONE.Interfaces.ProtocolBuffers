<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: claros_common_form_formtemplate.proto

namespace Claros\Common\Form;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Generated from protobuf message <code>claros.common.form.FormTemplate</code>
 */
class FormTemplate extends \Google\Protobuf\Internal\Message
{
    /**
     *retrieval only
     *
     * Generated from protobuf field <code>string id = 1;</code>
     */
    private $id = '';
    /**
     *update and retrieval only
     *
     * Generated from protobuf field <code>string ownerId = 2;</code>
     */
    private $ownerId = '';
    /**
     * Generated from protobuf field <code>bool public = 3;</code>
     */
    private $public = false;
    /**
     *retrieval only
     *
     * Generated from protobuf field <code>uint32 version = 4;</code>
     */
    private $version = 0;
    /**
     * Generated from protobuf field <code>map<string, .claros.common.configuration.Rights> privileges = 5;</code>
     */
    private $privileges;
    /**
     *This is the JSON stored data that exists in the ConfigurationData from the Claros.Common.Configuration serialized into the FormTemplateConfigurationData
     *
     * Generated from protobuf field <code>.claros.common.form.FormTemplateConfiguration formTemplateConfiguration = 6;</code>
     */
    private $formTemplateConfiguration = null;
    /**
     * Generated from protobuf field <code>string name = 7;</code>
     */
    private $name = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $id
     *          retrieval only
     *     @type string $ownerId
     *          update and retrieval only
     *     @type bool $public
     *     @type int $version
     *          retrieval only
     *     @type array|\Google\Protobuf\Internal\MapField $privileges
     *     @type \Claros\Common\Form\FormTemplateConfiguration $formTemplateConfiguration
     *          This is the JSON stored data that exists in the ConfigurationData from the Claros.Common.Configuration serialized into the FormTemplateConfigurationData
     *     @type string $name
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\ClarosCommonFormFormtemplate::initOnce();
        parent::__construct($data);
    }

    /**
     *retrieval only
     *
     * Generated from protobuf field <code>string id = 1;</code>
     * @return string
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     *retrieval only
     *
     * Generated from protobuf field <code>string id = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setId($var)
    {
        GPBUtil::checkString($var, True);
        $this->id = $var;

        return $this;
    }

    /**
     *update and retrieval only
     *
     * Generated from protobuf field <code>string ownerId = 2;</code>
     * @return string
     */
    public function getOwnerId()
    {
        return $this->ownerId;
    }

    /**
     *update and retrieval only
     *
     * Generated from protobuf field <code>string ownerId = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setOwnerId($var)
    {
        GPBUtil::checkString($var, True);
        $this->ownerId = $var;

        return $this;
    }

    /**
     * Generated from protobuf field <code>bool public = 3;</code>
     * @return bool
     */
    public function getPublic()
    {
        return $this->public;
    }

    /**
     * Generated from protobuf field <code>bool public = 3;</code>
     * @param bool $var
     * @return $this
     */
    public function setPublic($var)
    {
        GPBUtil::checkBool($var);
        $this->public = $var;

        return $this;
    }

    /**
     *retrieval only
     *
     * Generated from protobuf field <code>uint32 version = 4;</code>
     * @return int
     */
    public function getVersion()
    {
        return $this->version;
    }

    /**
     *retrieval only
     *
     * Generated from protobuf field <code>uint32 version = 4;</code>
     * @param int $var
     * @return $this
     */
    public function setVersion($var)
    {
        GPBUtil::checkUint32($var);
        $this->version = $var;

        return $this;
    }

    /**
     * Generated from protobuf field <code>map<string, .claros.common.configuration.Rights> privileges = 5;</code>
     * @return \Google\Protobuf\Internal\MapField
     */
    public function getPrivileges()
    {
        return $this->privileges;
    }

    /**
     * Generated from protobuf field <code>map<string, .claros.common.configuration.Rights> privileges = 5;</code>
     * @param array|\Google\Protobuf\Internal\MapField $var
     * @return $this
     */
    public function setPrivileges($var)
    {
        $arr = GPBUtil::checkMapField($var, \Google\Protobuf\Internal\GPBType::STRING, \Google\Protobuf\Internal\GPBType::MESSAGE, \Claros\Common\Configuration\Rights::class);
        $this->privileges = $arr;

        return $this;
    }

    /**
     *This is the JSON stored data that exists in the ConfigurationData from the Claros.Common.Configuration serialized into the FormTemplateConfigurationData
     *
     * Generated from protobuf field <code>.claros.common.form.FormTemplateConfiguration formTemplateConfiguration = 6;</code>
     * @return \Claros\Common\Form\FormTemplateConfiguration
     */
    public function getFormTemplateConfiguration()
    {
        return $this->formTemplateConfiguration;
    }

    /**
     *This is the JSON stored data that exists in the ConfigurationData from the Claros.Common.Configuration serialized into the FormTemplateConfigurationData
     *
     * Generated from protobuf field <code>.claros.common.form.FormTemplateConfiguration formTemplateConfiguration = 6;</code>
     * @param \Claros\Common\Form\FormTemplateConfiguration $var
     * @return $this
     */
    public function setFormTemplateConfiguration($var)
    {
        GPBUtil::checkMessage($var, \Claros\Common\Form\FormTemplateConfiguration::class);
        $this->formTemplateConfiguration = $var;

        return $this;
    }

    /**
     * Generated from protobuf field <code>string name = 7;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Generated from protobuf field <code>string name = 7;</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

}

