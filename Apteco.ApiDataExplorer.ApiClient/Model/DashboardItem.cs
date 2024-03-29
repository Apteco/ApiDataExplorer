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
    /// The definition of one item to show in a dashboard composition
    /// </summary>
    [DataContract]
    public partial class DashboardItem :  IEquatable<DashboardItem>
    {
        /// <summary>
        /// The type of chart to use to display this dashboard item
        /// </summary>
        /// <value>The type of chart to use to display this dashboard item</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChartTypeEnum
        {
            
            /// <summary>
            /// Enum Bar for value: Bar
            /// </summary>
            [EnumMember(Value = "Bar")]
            Bar = 1,
            
            /// <summary>
            /// Enum Column for value: Column
            /// </summary>
            [EnumMember(Value = "Column")]
            Column = 2,
            
            /// <summary>
            /// Enum Pie for value: Pie
            /// </summary>
            [EnumMember(Value = "Pie")]
            Pie = 3,
            
            /// <summary>
            /// Enum Donut for value: Donut
            /// </summary>
            [EnumMember(Value = "Donut")]
            Donut = 4,
            
            /// <summary>
            /// Enum Area for value: Area
            /// </summary>
            [EnumMember(Value = "Area")]
            Area = 5,
            
            /// <summary>
            /// Enum Funnel for value: Funnel
            /// </summary>
            [EnumMember(Value = "Funnel")]
            Funnel = 6,
            
            /// <summary>
            /// Enum Line for value: Line
            /// </summary>
            [EnumMember(Value = "Line")]
            Line = 7,
            
            /// <summary>
            /// Enum Radar for value: Radar
            /// </summary>
            [EnumMember(Value = "Radar")]
            Radar = 8
        }

        /// <summary>
        /// The type of chart to use to display this dashboard item
        /// </summary>
        /// <value>The type of chart to use to display this dashboard item</value>
        [DataMember(Name="chartType", EmitDefaultValue=false)]
        public ChartTypeEnum ChartType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DashboardItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardItem" /> class.
        /// </summary>
        /// <param name="VariableName">The name of the FastStats variable to use to calculate this dashboard item (required).</param>
        /// <param name="Size">The size of the dashboard item within this composition (required).</param>
        /// <param name="ChartType">The type of chart to use to display this dashboard item (required).</param>
        /// <param name="Description">The description to use for this item (required).</param>
        public DashboardItem(string VariableName = default(string), Size Size = default(Size), ChartTypeEnum ChartType = default(ChartTypeEnum), string Description = default(string))
        {
            // to ensure "VariableName" is required (not null)
            if (VariableName == null)
            {
                throw new InvalidDataException("VariableName is a required property for DashboardItem and cannot be null");
            }
            else
            {
                this.VariableName = VariableName;
            }
            // to ensure "Size" is required (not null)
            if (Size == null)
            {
                throw new InvalidDataException("Size is a required property for DashboardItem and cannot be null");
            }
            else
            {
                this.Size = Size;
            }
            // to ensure "ChartType" is required (not null)
            if (ChartType == null)
            {
                throw new InvalidDataException("ChartType is a required property for DashboardItem and cannot be null");
            }
            else
            {
                this.ChartType = ChartType;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for DashboardItem and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
        }
        
        /// <summary>
        /// The name of the FastStats variable to use to calculate this dashboard item
        /// </summary>
        /// <value>The name of the FastStats variable to use to calculate this dashboard item</value>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }

        /// <summary>
        /// The size of the dashboard item within this composition
        /// </summary>
        /// <value>The size of the dashboard item within this composition</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public Size Size { get; set; }


        /// <summary>
        /// The description to use for this item
        /// </summary>
        /// <value>The description to use for this item</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashboardItem {\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  ChartType: ").Append(ChartType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as DashboardItem);
        }

        /// <summary>
        /// Returns true if DashboardItem instances are equal
        /// </summary>
        /// <param name="input">Instance of DashboardItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VariableName == input.VariableName ||
                    (this.VariableName != null &&
                    this.VariableName.Equals(input.VariableName))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ChartType == input.ChartType ||
                    (this.ChartType != null &&
                    this.ChartType.Equals(input.ChartType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.VariableName != null)
                    hashCode = hashCode * 59 + this.VariableName.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ChartType != null)
                    hashCode = hashCode * 59 + this.ChartType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }

}
