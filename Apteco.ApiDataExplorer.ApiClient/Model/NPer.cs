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
    /// NPer
    /// </summary>
    [DataContract]
    public partial class NPer :  IEquatable<NPer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NPer" /> class.
        /// </summary>
        /// <param name="Recency">Recency.</param>
        /// <param name="GroupingTableName">GroupingTableName.</param>
        /// <param name="TransactionalTableName">TransactionalTableName.</param>
        public NPer(RFVRecency Recency = default(RFVRecency), string GroupingTableName = default(string), string TransactionalTableName = default(string))
        {
            this.Recency = Recency;
            this.GroupingTableName = GroupingTableName;
            this.TransactionalTableName = TransactionalTableName;
        }
        
        /// <summary>
        /// Gets or Sets Recency
        /// </summary>
        [DataMember(Name="recency", EmitDefaultValue=false)]
        public RFVRecency Recency { get; set; }

        /// <summary>
        /// Gets or Sets GroupingTableName
        /// </summary>
        [DataMember(Name="groupingTableName", EmitDefaultValue=false)]
        public string GroupingTableName { get; set; }

        /// <summary>
        /// Gets or Sets TransactionalTableName
        /// </summary>
        [DataMember(Name="transactionalTableName", EmitDefaultValue=false)]
        public string TransactionalTableName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NPer {\n");
            sb.Append("  Recency: ").Append(Recency).Append("\n");
            sb.Append("  GroupingTableName: ").Append(GroupingTableName).Append("\n");
            sb.Append("  TransactionalTableName: ").Append(TransactionalTableName).Append("\n");
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
            return this.Equals(input as NPer);
        }

        /// <summary>
        /// Returns true if NPer instances are equal
        /// </summary>
        /// <param name="input">Instance of NPer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NPer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Recency == input.Recency ||
                    (this.Recency != null &&
                    this.Recency.Equals(input.Recency))
                ) && 
                (
                    this.GroupingTableName == input.GroupingTableName ||
                    (this.GroupingTableName != null &&
                    this.GroupingTableName.Equals(input.GroupingTableName))
                ) && 
                (
                    this.TransactionalTableName == input.TransactionalTableName ||
                    (this.TransactionalTableName != null &&
                    this.TransactionalTableName.Equals(input.TransactionalTableName))
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
                if (this.Recency != null)
                    hashCode = hashCode * 59 + this.Recency.GetHashCode();
                if (this.GroupingTableName != null)
                    hashCode = hashCode * 59 + this.GroupingTableName.GetHashCode();
                if (this.TransactionalTableName != null)
                    hashCode = hashCode * 59 + this.TransactionalTableName.GetHashCode();
                return hashCode;
            }
        }
    }

}
