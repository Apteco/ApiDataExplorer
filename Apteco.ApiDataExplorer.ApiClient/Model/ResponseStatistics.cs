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
    /// Response statistics
    /// </summary>
    [DataContract]
    public partial class ResponseStatistics :  IEquatable<ResponseStatistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStatistics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseStatistics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStatistics" /> class.
        /// </summary>
        /// <param name="Days">The set of days where response information is available (required).</param>
        /// <param name="PerResponseTypeStatisticsMap">PerResponseTypeStatisticsMap (required).</param>
        /// <param name="StatisticsTimestamp">The date and time that the response statistics were calculated.</param>
        public ResponseStatistics(List<string> Days = default(List<string>), ResponseStatisticsPerResponseTypeStatisticsMap PerResponseTypeStatisticsMap = default(ResponseStatisticsPerResponseTypeStatisticsMap), DateTime? StatisticsTimestamp = default(DateTime?))
        {
            // to ensure "Days" is required (not null)
            if (Days == null)
            {
                throw new InvalidDataException("Days is a required property for ResponseStatistics and cannot be null");
            }
            else
            {
                this.Days = Days;
            }
            // to ensure "PerResponseTypeStatisticsMap" is required (not null)
            if (PerResponseTypeStatisticsMap == null)
            {
                throw new InvalidDataException("PerResponseTypeStatisticsMap is a required property for ResponseStatistics and cannot be null");
            }
            else
            {
                this.PerResponseTypeStatisticsMap = PerResponseTypeStatisticsMap;
            }
            this.StatisticsTimestamp = StatisticsTimestamp;
        }
        
        /// <summary>
        /// The set of days where response information is available
        /// </summary>
        /// <value>The set of days where response information is available</value>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public List<string> Days { get; set; }

        /// <summary>
        /// Gets or Sets PerResponseTypeStatisticsMap
        /// </summary>
        [DataMember(Name="perResponseTypeStatisticsMap", EmitDefaultValue=false)]
        public ResponseStatisticsPerResponseTypeStatisticsMap PerResponseTypeStatisticsMap { get; set; }

        /// <summary>
        /// The date and time that the response statistics were calculated
        /// </summary>
        /// <value>The date and time that the response statistics were calculated</value>
        [DataMember(Name="statisticsTimestamp", EmitDefaultValue=false)]
        public DateTime? StatisticsTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseStatistics {\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  PerResponseTypeStatisticsMap: ").Append(PerResponseTypeStatisticsMap).Append("\n");
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
            return this.Equals(input as ResponseStatistics);
        }

        /// <summary>
        /// Returns true if ResponseStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Days == input.Days ||
                    this.Days != null &&
                    this.Days.SequenceEqual(input.Days)
                ) && 
                (
                    this.PerResponseTypeStatisticsMap == input.PerResponseTypeStatisticsMap ||
                    (this.PerResponseTypeStatisticsMap != null &&
                    this.PerResponseTypeStatisticsMap.Equals(input.PerResponseTypeStatisticsMap))
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
                if (this.Days != null)
                    hashCode = hashCode * 59 + this.Days.GetHashCode();
                if (this.PerResponseTypeStatisticsMap != null)
                    hashCode = hashCode * 59 + this.PerResponseTypeStatisticsMap.GetHashCode();
                if (this.StatisticsTimestamp != null)
                    hashCode = hashCode * 59 + this.StatisticsTimestamp.GetHashCode();
                return hashCode;
            }
        }
    }

}
