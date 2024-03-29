/* 
 * Apteco API
 *
 * An API to allow access to Apteco Marketing Suite resources
 *
 * OpenAPI spec version: v2
 * Contact: support@apteco.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Apteco.ApiDataExplorer.ApiClient.Client.SwaggerDateConverter;

namespace Apteco.ApiDataExplorer.ApiClient.Model
{
    /// <summary>
    /// Status information for a PeopleStage element
    /// </summary>
    [DataContract]
    public partial class ElementStatus :  IEquatable<ElementStatus>
    {
        /// <summary>
        /// The element&#39;s type
        /// </summary>
        /// <value>The element&#39;s type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum Diagram for value: Diagram
            /// </summary>
            [EnumMember(Value = "Diagram")]
            Diagram = 2,
            
            /// <summary>
            /// Enum Programme for value: Programme
            /// </summary>
            [EnumMember(Value = "Programme")]
            Programme = 3,
            
            /// <summary>
            /// Enum Area for value: Area
            /// </summary>
            [EnumMember(Value = "Area")]
            Area = 4,
            
            /// <summary>
            /// Enum Campaign for value: Campaign
            /// </summary>
            [EnumMember(Value = "Campaign")]
            Campaign = 5,
            
            /// <summary>
            /// Enum Message for value: Message
            /// </summary>
            [EnumMember(Value = "Message")]
            Message = 6,
            
            /// <summary>
            /// Enum Group for value: Group
            /// </summary>
            [EnumMember(Value = "Group")]
            Group = 7,
            
            /// <summary>
            /// Enum Audience for value: Audience
            /// </summary>
            [EnumMember(Value = "Audience")]
            Audience = 8,
            
            /// <summary>
            /// Enum Content for value: Content
            /// </summary>
            [EnumMember(Value = "Content")]
            Content = 9,
            
            /// <summary>
            /// Enum Delivery for value: Delivery
            /// </summary>
            [EnumMember(Value = "Delivery")]
            Delivery = 10,
            
            /// <summary>
            /// Enum Pool for value: Pool
            /// </summary>
            [EnumMember(Value = "Pool")]
            Pool = 11,
            
            /// <summary>
            /// Enum Responses for value: Responses
            /// </summary>
            [EnumMember(Value = "Responses")]
            Responses = 12,
            
            /// <summary>
            /// Enum Transition for value: Transition
            /// </summary>
            [EnumMember(Value = "Transition")]
            Transition = 13,
            
            /// <summary>
            /// Enum PauseAction for value: PauseAction
            /// </summary>
            [EnumMember(Value = "PauseAction")]
            PauseAction = 14
        }

        /// <summary>
        /// The element&#39;s type
        /// </summary>
        /// <value>The element&#39;s type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Defines ChannelTypes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelTypesEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum Control for value: Control
            /// </summary>
            [EnumMember(Value = "Control")]
            Control = 2,
            
            /// <summary>
            /// Enum Broadcast for value: Broadcast
            /// </summary>
            [EnumMember(Value = "Broadcast")]
            Broadcast = 3,
            
            /// <summary>
            /// Enum File for value: File
            /// </summary>
            [EnumMember(Value = "File")]
            File = 4,
            
            /// <summary>
            /// Enum Ftp for value: Ftp
            /// </summary>
            [EnumMember(Value = "Ftp")]
            Ftp = 5,
            
            /// <summary>
            /// Enum Facebook for value: Facebook
            /// </summary>
            [EnumMember(Value = "Facebook")]
            Facebook = 6,
            
            /// <summary>
            /// Enum MicrosoftDynamics for value: MicrosoftDynamics
            /// </summary>
            [EnumMember(Value = "MicrosoftDynamics")]
            MicrosoftDynamics = 7,
            
            /// <summary>
            /// Enum SalesForce for value: SalesForce
            /// </summary>
            [EnumMember(Value = "SalesForce")]
            SalesForce = 8,
            
            /// <summary>
            /// Enum PushNotification for value: PushNotification
            /// </summary>
            [EnumMember(Value = "PushNotification")]
            PushNotification = 9,
            
            /// <summary>
            /// Enum Twitter for value: Twitter
            /// </summary>
            [EnumMember(Value = "Twitter")]
            Twitter = 10,
            
            /// <summary>
            /// Enum Google for value: Google
            /// </summary>
            [EnumMember(Value = "Google")]
            Google = 11,
            
            /// <summary>
            /// Enum Composite for value: Composite
            /// </summary>
            [EnumMember(Value = "Composite")]
            Composite = 12
        }


        /// <summary>
        /// The different types of channel that have been used by deliveries within this element
        /// </summary>
        /// <value>The different types of channel that have been used by deliveries within this element</value>
        [DataMember(Name="channelTypes", EmitDefaultValue=false)]
        public List<ChannelTypesEnum> ChannelTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ElementStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementStatus" /> class.
        /// </summary>
        /// <param name="Id">The element&#39;s id (required).</param>
        /// <param name="Description">The element&#39;s description (required).</param>
        /// <param name="Type">The element&#39;s type (required).</param>
        /// <param name="SuccessfulCampaignsCount">The number of campaigns that currently have a success status within this element.</param>
        /// <param name="ErroredCampaignsCount">The number of campaigns that currently have an errored status within this element.</param>
        /// <param name="InactiveCampaignsCount">The number of campaigns that currently have an inactive status within this element.</param>
        /// <param name="NeedsApprovalCampaignsCount">The number of campaigns that currently have a message that needs approval within this element.</param>
        /// <param name="ChannelTypes">The different types of channel that have been used by deliveries within this element.</param>
        /// <param name="FirstRan">The first time that any deliveries ran within this element.</param>
        /// <param name="LastRan">The last time that any deliveries ran within this element.</param>
        /// <param name="StatisticsTimestamp">The date and time that the statistics were calculated.</param>
        public ElementStatus(string Id = default(string), string Description = default(string), TypeEnum Type = default(TypeEnum), int? SuccessfulCampaignsCount = default(int?), int? ErroredCampaignsCount = default(int?), int? InactiveCampaignsCount = default(int?), int? NeedsApprovalCampaignsCount = default(int?), List<ChannelTypesEnum> ChannelTypes = default(List<ChannelTypesEnum>), DateTime? FirstRan = default(DateTime?), DateTime? LastRan = default(DateTime?), DateTime? StatisticsTimestamp = default(DateTime?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ElementStatus and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for ElementStatus and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for ElementStatus and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.SuccessfulCampaignsCount = SuccessfulCampaignsCount;
            this.ErroredCampaignsCount = ErroredCampaignsCount;
            this.InactiveCampaignsCount = InactiveCampaignsCount;
            this.NeedsApprovalCampaignsCount = NeedsApprovalCampaignsCount;
            this.ChannelTypes = ChannelTypes;
            this.FirstRan = FirstRan;
            this.LastRan = LastRan;
            this.StatisticsTimestamp = StatisticsTimestamp;
        }
        
        /// <summary>
        /// The element&#39;s id
        /// </summary>
        /// <value>The element&#39;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The element&#39;s description
        /// </summary>
        /// <value>The element&#39;s description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// The number of campaigns that currently have a success status within this element
        /// </summary>
        /// <value>The number of campaigns that currently have a success status within this element</value>
        [DataMember(Name="successfulCampaignsCount", EmitDefaultValue=false)]
        public int? SuccessfulCampaignsCount { get; set; }

        /// <summary>
        /// The number of campaigns that currently have an errored status within this element
        /// </summary>
        /// <value>The number of campaigns that currently have an errored status within this element</value>
        [DataMember(Name="erroredCampaignsCount", EmitDefaultValue=false)]
        public int? ErroredCampaignsCount { get; set; }

        /// <summary>
        /// The number of campaigns that currently have an inactive status within this element
        /// </summary>
        /// <value>The number of campaigns that currently have an inactive status within this element</value>
        [DataMember(Name="inactiveCampaignsCount", EmitDefaultValue=false)]
        public int? InactiveCampaignsCount { get; set; }

        /// <summary>
        /// The number of campaigns that currently have a message that needs approval within this element
        /// </summary>
        /// <value>The number of campaigns that currently have a message that needs approval within this element</value>
        [DataMember(Name="needsApprovalCampaignsCount", EmitDefaultValue=false)]
        public int? NeedsApprovalCampaignsCount { get; set; }


        /// <summary>
        /// The first time that any deliveries ran within this element
        /// </summary>
        /// <value>The first time that any deliveries ran within this element</value>
        [DataMember(Name="firstRan", EmitDefaultValue=false)]
        public DateTime? FirstRan { get; set; }

        /// <summary>
        /// The last time that any deliveries ran within this element
        /// </summary>
        /// <value>The last time that any deliveries ran within this element</value>
        [DataMember(Name="lastRan", EmitDefaultValue=false)]
        public DateTime? LastRan { get; set; }

        /// <summary>
        /// The date and time that the statistics were calculated
        /// </summary>
        /// <value>The date and time that the statistics were calculated</value>
        [DataMember(Name="statisticsTimestamp", EmitDefaultValue=false)]
        public DateTime? StatisticsTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElementStatus {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SuccessfulCampaignsCount: ").Append(SuccessfulCampaignsCount).Append("\n");
            sb.Append("  ErroredCampaignsCount: ").Append(ErroredCampaignsCount).Append("\n");
            sb.Append("  InactiveCampaignsCount: ").Append(InactiveCampaignsCount).Append("\n");
            sb.Append("  NeedsApprovalCampaignsCount: ").Append(NeedsApprovalCampaignsCount).Append("\n");
            sb.Append("  ChannelTypes: ").Append(ChannelTypes).Append("\n");
            sb.Append("  FirstRan: ").Append(FirstRan).Append("\n");
            sb.Append("  LastRan: ").Append(LastRan).Append("\n");
            sb.Append("  StatisticsTimestamp: ").Append(StatisticsTimestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ElementStatus);
        }

        /// <summary>
        /// Returns true if ElementStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ElementStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElementStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SuccessfulCampaignsCount == input.SuccessfulCampaignsCount ||
                    (this.SuccessfulCampaignsCount != null &&
                    this.SuccessfulCampaignsCount.Equals(input.SuccessfulCampaignsCount))
                ) && 
                (
                    this.ErroredCampaignsCount == input.ErroredCampaignsCount ||
                    (this.ErroredCampaignsCount != null &&
                    this.ErroredCampaignsCount.Equals(input.ErroredCampaignsCount))
                ) && 
                (
                    this.InactiveCampaignsCount == input.InactiveCampaignsCount ||
                    (this.InactiveCampaignsCount != null &&
                    this.InactiveCampaignsCount.Equals(input.InactiveCampaignsCount))
                ) && 
                (
                    this.NeedsApprovalCampaignsCount == input.NeedsApprovalCampaignsCount ||
                    (this.NeedsApprovalCampaignsCount != null &&
                    this.NeedsApprovalCampaignsCount.Equals(input.NeedsApprovalCampaignsCount))
                ) && 
                (
                    this.ChannelTypes == input.ChannelTypes ||
                    this.ChannelTypes != null &&
                    this.ChannelTypes.SequenceEqual(input.ChannelTypes)
                ) && 
                (
                    this.FirstRan == input.FirstRan ||
                    (this.FirstRan != null &&
                    this.FirstRan.Equals(input.FirstRan))
                ) && 
                (
                    this.LastRan == input.LastRan ||
                    (this.LastRan != null &&
                    this.LastRan.Equals(input.LastRan))
                ) && 
                (
                    this.StatisticsTimestamp == input.StatisticsTimestamp ||
                    (this.StatisticsTimestamp != null &&
                    this.StatisticsTimestamp.Equals(input.StatisticsTimestamp))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SuccessfulCampaignsCount != null)
                    hashCode = hashCode * 59 + this.SuccessfulCampaignsCount.GetHashCode();
                if (this.ErroredCampaignsCount != null)
                    hashCode = hashCode * 59 + this.ErroredCampaignsCount.GetHashCode();
                if (this.InactiveCampaignsCount != null)
                    hashCode = hashCode * 59 + this.InactiveCampaignsCount.GetHashCode();
                if (this.NeedsApprovalCampaignsCount != null)
                    hashCode = hashCode * 59 + this.NeedsApprovalCampaignsCount.GetHashCode();
                if (this.ChannelTypes != null)
                    hashCode = hashCode * 59 + this.ChannelTypes.GetHashCode();
                if (this.FirstRan != null)
                    hashCode = hashCode * 59 + this.FirstRan.GetHashCode();
                if (this.LastRan != null)
                    hashCode = hashCode * 59 + this.LastRan.GetHashCode();
                if (this.StatisticsTimestamp != null)
                    hashCode = hashCode * 59 + this.StatisticsTimestamp.GetHashCode();
                return hashCode;
            }
        }
    }

}
