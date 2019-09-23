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
    /// Top level details for a FastStats system
    /// </summary>
    [DataContract]
    public partial class FastStatsSystemDetail :  IEquatable<FastStatsSystemDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FastStatsSystemDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FastStatsSystemDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FastStatsSystemDetail" /> class.
        /// </summary>
        /// <param name="Name">The name of the FastStats system held in the API&#39;s configuration (required).</param>
        /// <param name="ViewName">The name of the FastStats system as defined when the system was built (required).</param>
        /// <param name="Description">The description for the FastStats system (required).</param>
        /// <param name="FastStatsBuildDate">The date and time that the FastStats system was built.</param>
        public FastStatsSystemDetail(string Name = default(string), string ViewName = default(string), string Description = default(string), DateTime? FastStatsBuildDate = default(DateTime?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for FastStatsSystemDetail and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ViewName" is required (not null)
            if (ViewName == null)
            {
                throw new InvalidDataException("ViewName is a required property for FastStatsSystemDetail and cannot be null");
            }
            else
            {
                this.ViewName = ViewName;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for FastStatsSystemDetail and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            this.FastStatsBuildDate = FastStatsBuildDate;
        }
        
        /// <summary>
        /// The name of the FastStats system held in the API&#39;s configuration
        /// </summary>
        /// <value>The name of the FastStats system held in the API&#39;s configuration</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the FastStats system as defined when the system was built
        /// </summary>
        /// <value>The name of the FastStats system as defined when the system was built</value>
        [DataMember(Name="viewName", EmitDefaultValue=false)]
        public string ViewName { get; set; }

        /// <summary>
        /// The description for the FastStats system
        /// </summary>
        /// <value>The description for the FastStats system</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The date and time that the FastStats system was built
        /// </summary>
        /// <value>The date and time that the FastStats system was built</value>
        [DataMember(Name="fastStatsBuildDate", EmitDefaultValue=false)]
        public DateTime? FastStatsBuildDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FastStatsSystemDetail {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ViewName: ").Append(ViewName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FastStatsBuildDate: ").Append(FastStatsBuildDate).Append("\n");
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
            return this.Equals(input as FastStatsSystemDetail);
        }

        /// <summary>
        /// Returns true if FastStatsSystemDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of FastStatsSystemDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FastStatsSystemDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FastStatsBuildDate == input.FastStatsBuildDate ||
                    (this.FastStatsBuildDate != null &&
                    this.FastStatsBuildDate.Equals(input.FastStatsBuildDate))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FastStatsBuildDate != null)
                    hashCode = hashCode * 59 + this.FastStatsBuildDate.GetHashCode();
                return hashCode;
            }
        }
    }

}
