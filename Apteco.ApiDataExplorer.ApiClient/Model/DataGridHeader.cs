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
    /// Details about the Headers in a DataGrid
    /// </summary>
    [DataContract]
    public partial class DataGridHeader :  IEquatable<DataGridHeader>
    {
        /// <summary>
        /// The type of data in this column
        /// </summary>
        /// <value>The type of data in this column</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColumnDataTypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum Date for value: Date
            /// </summary>
            [EnumMember(Value = "Date")]
            Date = 2,
            
            /// <summary>
            /// Enum DateTime for value: DateTime
            /// </summary>
            [EnumMember(Value = "DateTime")]
            DateTime = 3,
            
            /// <summary>
            /// Enum Numeric for value: Numeric
            /// </summary>
            [EnumMember(Value = "Numeric")]
            Numeric = 4,
            
            /// <summary>
            /// Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")]
            Text = 5
        }

        /// <summary>
        /// The type of data in this column
        /// </summary>
        /// <value>The type of data in this column</value>
        [DataMember(Name="columnDataType", EmitDefaultValue=false)]
        public ColumnDataTypeEnum? ColumnDataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataGridHeader" /> class.
        /// </summary>
        /// <param name="Value">Value of the column header.</param>
        /// <param name="ColumnDataType">The type of data in this column.</param>
        public DataGridHeader(string Value = default(string), ColumnDataTypeEnum? ColumnDataType = default(ColumnDataTypeEnum?))
        {
            this.Value = Value;
            this.ColumnDataType = ColumnDataType;
        }
        
        /// <summary>
        /// Value of the column header
        /// </summary>
        /// <value>Value of the column header</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataGridHeader {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ColumnDataType: ").Append(ColumnDataType).Append("\n");
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
            return this.Equals(input as DataGridHeader);
        }

        /// <summary>
        /// Returns true if DataGridHeader instances are equal
        /// </summary>
        /// <param name="input">Instance of DataGridHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataGridHeader input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ColumnDataType == input.ColumnDataType ||
                    (this.ColumnDataType != null &&
                    this.ColumnDataType.Equals(input.ColumnDataType))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ColumnDataType != null)
                    hashCode = hashCode * 59 + this.ColumnDataType.GetHashCode();
                return hashCode;
            }
        }
    }

}
