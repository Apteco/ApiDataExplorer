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
    /// TimeRule
    /// </summary>
    [DataContract]
    public partial class TimeRule :  IEquatable<TimeRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRule" /> class.
        /// </summary>
        /// <param name="RangeLow">RangeLow.</param>
        /// <param name="RangeHigh">RangeHigh.</param>
        public TimeRule(string RangeLow = default(string), string RangeHigh = default(string))
        {
            this.RangeLow = RangeLow;
            this.RangeHigh = RangeHigh;
        }
        
        /// <summary>
        /// Gets or Sets RangeLow
        /// </summary>
        [DataMember(Name="rangeLow", EmitDefaultValue=false)]
        public string RangeLow { get; set; }

        /// <summary>
        /// Gets or Sets RangeHigh
        /// </summary>
        [DataMember(Name="rangeHigh", EmitDefaultValue=false)]
        public string RangeHigh { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeRule {\n");
            sb.Append("  RangeLow: ").Append(RangeLow).Append("\n");
            sb.Append("  RangeHigh: ").Append(RangeHigh).Append("\n");
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
            return this.Equals(input as TimeRule);
        }

        /// <summary>
        /// Returns true if TimeRule instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RangeLow == input.RangeLow ||
                    (this.RangeLow != null &&
                    this.RangeLow.Equals(input.RangeLow))
                ) && 
                (
                    this.RangeHigh == input.RangeHigh ||
                    (this.RangeHigh != null &&
                    this.RangeHigh.Equals(input.RangeHigh))
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
                if (this.RangeLow != null)
                    hashCode = hashCode * 59 + this.RangeLow.GetHashCode();
                if (this.RangeHigh != null)
                    hashCode = hashCode * 59 + this.RangeHigh.GetHashCode();
                return hashCode;
            }
        }
    }

}
