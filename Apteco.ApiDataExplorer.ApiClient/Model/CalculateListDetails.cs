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
    /// The details required to perform a count of a list
    /// </summary>
    [DataContract]
    public partial class CalculateListDetails :  IEquatable<CalculateListDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateListDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CalculateListDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateListDetails" /> class.
        /// </summary>
        /// <param name="GenerateUrnFile">Whether to generate a URN file with this count or not (required).</param>
        public CalculateListDetails(bool? GenerateUrnFile = default(bool?))
        {
            // to ensure "GenerateUrnFile" is required (not null)
            if (GenerateUrnFile == null)
            {
                throw new InvalidDataException("GenerateUrnFile is a required property for CalculateListDetails and cannot be null");
            }
            else
            {
                this.GenerateUrnFile = GenerateUrnFile;
            }
        }
        
        /// <summary>
        /// Whether to generate a URN file with this count or not
        /// </summary>
        /// <value>Whether to generate a URN file with this count or not</value>
        [DataMember(Name="generateUrnFile", EmitDefaultValue=false)]
        public bool? GenerateUrnFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalculateListDetails {\n");
            sb.Append("  GenerateUrnFile: ").Append(GenerateUrnFile).Append("\n");
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
            return this.Equals(input as CalculateListDetails);
        }

        /// <summary>
        /// Returns true if CalculateListDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculateListDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculateListDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GenerateUrnFile == input.GenerateUrnFile ||
                    (this.GenerateUrnFile != null &&
                    this.GenerateUrnFile.Equals(input.GenerateUrnFile))
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
                if (this.GenerateUrnFile != null)
                    hashCode = hashCode * 59 + this.GenerateUrnFile.GetHashCode();
                return hashCode;
            }
        }
    }

}
