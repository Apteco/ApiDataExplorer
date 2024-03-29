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
    /// Communication statistics for the specified date range
    /// </summary>
    [DataContract]
    public partial class RangeStatistics :  IEquatable<RangeStatistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RangeStatistics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RangeStatistics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RangeStatistics" /> class.
        /// </summary>
        /// <param name="Id">The element&#39;s id (required).</param>
        /// <param name="CommunicationsCount">The number of communications sent within this element during the specified date range.</param>
        /// <param name="DeliveriesCount">The number of deliveries that have run within this element during the specified date range.</param>
        /// <param name="MessagesCount">The number of messages that have had at least one delivery run within this element during the specified date range.</param>
        /// <param name="CampaignsCount">The number of campaigns that have had at least one delivery run within this element during the specified date range.</param>
        /// <param name="FirstRan">The first time that any deliveries ran within this element during the specified date range.</param>
        /// <param name="LastRan">The last time that any deliveries ran within this element during the specified date range.</param>
        /// <param name="StatisticsTimestamp">The date and time that the campaign statistics were calculated.</param>
        public RangeStatistics(string Id = default(string), long? CommunicationsCount = default(long?), long? DeliveriesCount = default(long?), long? MessagesCount = default(long?), long? CampaignsCount = default(long?), DateTime? FirstRan = default(DateTime?), DateTime? LastRan = default(DateTime?), DateTime? StatisticsTimestamp = default(DateTime?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for RangeStatistics and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.CommunicationsCount = CommunicationsCount;
            this.DeliveriesCount = DeliveriesCount;
            this.MessagesCount = MessagesCount;
            this.CampaignsCount = CampaignsCount;
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
        /// The number of communications sent within this element during the specified date range
        /// </summary>
        /// <value>The number of communications sent within this element during the specified date range</value>
        [DataMember(Name="communicationsCount", EmitDefaultValue=false)]
        public long? CommunicationsCount { get; set; }

        /// <summary>
        /// The number of deliveries that have run within this element during the specified date range
        /// </summary>
        /// <value>The number of deliveries that have run within this element during the specified date range</value>
        [DataMember(Name="deliveriesCount", EmitDefaultValue=false)]
        public long? DeliveriesCount { get; set; }

        /// <summary>
        /// The number of messages that have had at least one delivery run within this element during the specified date range
        /// </summary>
        /// <value>The number of messages that have had at least one delivery run within this element during the specified date range</value>
        [DataMember(Name="messagesCount", EmitDefaultValue=false)]
        public long? MessagesCount { get; set; }

        /// <summary>
        /// The number of campaigns that have had at least one delivery run within this element during the specified date range
        /// </summary>
        /// <value>The number of campaigns that have had at least one delivery run within this element during the specified date range</value>
        [DataMember(Name="campaignsCount", EmitDefaultValue=false)]
        public long? CampaignsCount { get; set; }

        /// <summary>
        /// The first time that any deliveries ran within this element during the specified date range
        /// </summary>
        /// <value>The first time that any deliveries ran within this element during the specified date range</value>
        [DataMember(Name="firstRan", EmitDefaultValue=false)]
        public DateTime? FirstRan { get; set; }

        /// <summary>
        /// The last time that any deliveries ran within this element during the specified date range
        /// </summary>
        /// <value>The last time that any deliveries ran within this element during the specified date range</value>
        [DataMember(Name="lastRan", EmitDefaultValue=false)]
        public DateTime? LastRan { get; set; }

        /// <summary>
        /// The date and time that the campaign statistics were calculated
        /// </summary>
        /// <value>The date and time that the campaign statistics were calculated</value>
        [DataMember(Name="statisticsTimestamp", EmitDefaultValue=false)]
        public DateTime? StatisticsTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RangeStatistics {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CommunicationsCount: ").Append(CommunicationsCount).Append("\n");
            sb.Append("  DeliveriesCount: ").Append(DeliveriesCount).Append("\n");
            sb.Append("  MessagesCount: ").Append(MessagesCount).Append("\n");
            sb.Append("  CampaignsCount: ").Append(CampaignsCount).Append("\n");
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
            return this.Equals(input as RangeStatistics);
        }

        /// <summary>
        /// Returns true if RangeStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of RangeStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RangeStatistics input)
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
                    this.CommunicationsCount == input.CommunicationsCount ||
                    (this.CommunicationsCount != null &&
                    this.CommunicationsCount.Equals(input.CommunicationsCount))
                ) && 
                (
                    this.DeliveriesCount == input.DeliveriesCount ||
                    (this.DeliveriesCount != null &&
                    this.DeliveriesCount.Equals(input.DeliveriesCount))
                ) && 
                (
                    this.MessagesCount == input.MessagesCount ||
                    (this.MessagesCount != null &&
                    this.MessagesCount.Equals(input.MessagesCount))
                ) && 
                (
                    this.CampaignsCount == input.CampaignsCount ||
                    (this.CampaignsCount != null &&
                    this.CampaignsCount.Equals(input.CampaignsCount))
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
                if (this.CommunicationsCount != null)
                    hashCode = hashCode * 59 + this.CommunicationsCount.GetHashCode();
                if (this.DeliveriesCount != null)
                    hashCode = hashCode * 59 + this.DeliveriesCount.GetHashCode();
                if (this.MessagesCount != null)
                    hashCode = hashCode * 59 + this.MessagesCount.GetHashCode();
                if (this.CampaignsCount != null)
                    hashCode = hashCode * 59 + this.CampaignsCount.GetHashCode();
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
