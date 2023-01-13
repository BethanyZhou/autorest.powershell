// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Sample.Models
{
    using System.Linq;

    /// <summary>
    /// An event source that receives its data from an Azure IoTHub.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.IotHub")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class IoTHubEventSourceResource : EventSourceResource
    {
        /// <summary>
        /// Initializes a new instance of the IoTHubEventSourceResource class.
        /// </summary>
        public IoTHubEventSourceResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IoTHubEventSourceResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="eventSourceResourceId">The resource id of the event
        /// source in Azure Resource Manager.</param>
        /// <param name="iotHubName">The name of the iot hub.</param>
        /// <param name="consumerGroupName">The name of the iot hub's consumer
        /// group that holds the partitions from which events will be
        /// read.</param>
        /// <param name="keyName">The name of the Shared Access Policy key that
        /// grants the Time Series Insights service access to the iot hub. This
        /// shared access policy key must grant 'service connect' permissions
        /// to the iot hub.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">Provisioning state of the resource.
        /// Possible values include: 'Accepted', 'Creating', 'Updating',
        /// 'Succeeded', 'Failed', 'Deleting'</param>
        /// <param name="creationTime">The time the resource was
        /// created.</param>
        /// <param name="timestampPropertyName">The event property that will be
        /// used as the event source's timestamp. If a value isn't specified
        /// for timestampPropertyName, or if null or empty-string is specified,
        /// the event creation time will be used.</param>
        public IoTHubEventSourceResource(string location, string eventSourceResourceId, string iotHubName, string consumerGroupName, string keyName, string id = default(string), string name = default(string), string type = default(string), string tags = default(string), ProvisioningState? provisioningState = default(ProvisioningState?), System.DateTime? creationTime = default(System.DateTime?), string timestampPropertyName = default(string), bool? name = default(bool?))
            : base(location, id, name, type, tags)
        {
            this.ProvisioningState = provisioningState;
            this.CreationTime = creationTime;
            this.TimestampPropertyName = timestampPropertyName;
            this.EventSourceResourceId = eventSourceResourceId;
            this.IotHubName = iotHubName;
            this.ConsumerGroupName = consumerGroupName;
            this.KeyName = keyName;
            this.Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets provisioning state of the resource. Possible values
        /// include: 'Accepted', 'Creating', 'Updating', 'Succeeded', 'Failed',
        /// 'Deleting'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState {get; private set; }

        /// <summary>
        /// Gets the time the resource was created.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets or sets the event property that will be used as the event
        /// source's timestamp. If a value isn't specified for
        /// timestampPropertyName, or if null or empty-string is specified, the
        /// event creation time will be used.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.timestampPropertyName")]
        public string TimestampPropertyName { get; set; }

        /// <summary>
        /// Gets or sets the resource id of the event source in Azure Resource
        /// Manager.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.eventSourceResourceId")]
        public string EventSourceResourceId { get; set; }

        /// <summary>
        /// Gets or sets the name of the iot hub.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.iotHubName")]
        public string IotHubName { get; set; }

        /// <summary>
        /// Gets or sets the name of the iot hub's consumer group that holds
        /// the partitions from which events will be read.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.consumerGroupName")]
        public string ConsumerGroupName { get; set; }

        /// <summary>
        /// Gets or sets the name of the Shared Access Policy key that grants
        /// the Time Series Insights service access to the iot hub. This shared
        /// access policy key must grant 'service connect' permissions to the
        /// iot hub.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.keyName")]
        public string KeyName { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.name")]
        public bool? Name {get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.EventSourceResourceId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "EventSourceResourceId");
            }
            if (this.IotHubName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "IotHubName");
            }
            if (this.ConsumerGroupName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ConsumerGroupName");
            }
            if (this.KeyName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "KeyName");
            }
        }
    }
}
