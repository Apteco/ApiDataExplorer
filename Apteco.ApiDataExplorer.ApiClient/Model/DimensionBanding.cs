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
    /// Information on how to band up numeric or date variables for a cube dimension
    /// </summary>
    [DataContract]
    public partial class DimensionBanding :  IEquatable<DimensionBanding>
    {
        /// <summary>
        /// The type of banding to use
        /// </summary>
        /// <value>The type of banding to use</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Years for value: Years
            /// </summary>
            [EnumMember(Value = "Years")]
            Years = 2,
            
            /// <summary>
            /// Enum Quarters for value: Quarters
            /// </summary>
            [EnumMember(Value = "Quarters")]
            Quarters = 3,
            
            /// <summary>
            /// Enum Months for value: Months
            /// </summary>
            [EnumMember(Value = "Months")]
            Months = 4,
            
            /// <summary>
            /// Enum Weeks for value: Weeks
            /// </summary>
            [EnumMember(Value = "Weeks")]
            Weeks = 5,
            
            /// <summary>
            /// Enum DayOfWeek for value: DayOfWeek
            /// </summary>
            [EnumMember(Value = "DayOfWeek")]
            DayOfWeek = 6,
            
            /// <summary>
            /// Enum WeekOfYear for value: WeekOfYear
            /// </summary>
            [EnumMember(Value = "WeekOfYear")]
            WeekOfYear = 7,
            
            /// <summary>
            /// Enum MonthOfYear for value: MonthOfYear
            /// </summary>
            [EnumMember(Value = "MonthOfYear")]
            MonthOfYear = 8,
            
            /// <summary>
            /// Enum QuarterOfYear for value: QuarterOfYear
            /// </summary>
            [EnumMember(Value = "QuarterOfYear")]
            QuarterOfYear = 9,
            
            /// <summary>
            /// Enum DayMonthOfYear for value: DayMonthOfYear
            /// </summary>
            [EnumMember(Value = "DayMonthOfYear")]
            DayMonthOfYear = 10,
            
            /// <summary>
            /// Enum HourOfDay for value: HourOfDay
            /// </summary>
            [EnumMember(Value = "HourOfDay")]
            HourOfDay = 11,
            
            /// <summary>
            /// Enum DayHour for value: DayHour
            /// </summary>
            [EnumMember(Value = "DayHour")]
            DayHour = 12,
            
            /// <summary>
            /// Enum DayHourMinute for value: DayHourMinute
            /// </summary>
            [EnumMember(Value = "DayHourMinute")]
            DayHourMinute = 13,
            
            /// <summary>
            /// Enum Day for value: Day
            /// </summary>
            [EnumMember(Value = "Day")]
            Day = 14,
            
            /// <summary>
            /// Enum AgeInYears for value: AgeInYears
            /// </summary>
            [EnumMember(Value = "AgeInYears")]
            AgeInYears = 15,
            
            /// <summary>
            /// Enum AgeInMonths for value: AgeInMonths
            /// </summary>
            [EnumMember(Value = "AgeInMonths")]
            AgeInMonths = 16,
            
            /// <summary>
            /// Enum AgeInQuarters for value: AgeInQuarters
            /// </summary>
            [EnumMember(Value = "AgeInQuarters")]
            AgeInQuarters = 17,
            
            /// <summary>
            /// Enum AgeInWeeks for value: AgeInWeeks
            /// </summary>
            [EnumMember(Value = "AgeInWeeks")]
            AgeInWeeks = 18,
            
            /// <summary>
            /// Enum AgeInDays for value: AgeInDays
            /// </summary>
            [EnumMember(Value = "AgeInDays")]
            AgeInDays = 19,
            
            /// <summary>
            /// Enum YearsBusiness for value: YearsBusiness
            /// </summary>
            [EnumMember(Value = "YearsBusiness")]
            YearsBusiness = 20,
            
            /// <summary>
            /// Enum QuartersBusiness for value: QuartersBusiness
            /// </summary>
            [EnumMember(Value = "QuartersBusiness")]
            QuartersBusiness = 21,
            
            /// <summary>
            /// Enum QuarterOfYearBusiness for value: QuarterOfYearBusiness
            /// </summary>
            [EnumMember(Value = "QuarterOfYearBusiness")]
            QuarterOfYearBusiness = 22,
            
            /// <summary>
            /// Enum MonthsBusiness for value: MonthsBusiness
            /// </summary>
            [EnumMember(Value = "MonthsBusiness")]
            MonthsBusiness = 23,
            
            /// <summary>
            /// Enum MonthOfYearBusiness for value: MonthOfYearBusiness
            /// </summary>
            [EnumMember(Value = "MonthOfYearBusiness")]
            MonthOfYearBusiness = 24,
            
            /// <summary>
            /// Enum WeeksBusiness for value: WeeksBusiness
            /// </summary>
            [EnumMember(Value = "WeeksBusiness")]
            WeeksBusiness = 25,
            
            /// <summary>
            /// Enum DaysBusiness for value: DaysBusiness
            /// </summary>
            [EnumMember(Value = "DaysBusiness")]
            DaysBusiness = 26,
            
            /// <summary>
            /// Enum WeekOfYearBusiness for value: WeekOfYearBusiness
            /// </summary>
            [EnumMember(Value = "WeekOfYearBusiness")]
            WeekOfYearBusiness = 27,
            
            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 28
        }

        /// <summary>
        /// The type of banding to use
        /// </summary>
        /// <value>The type of banding to use</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionBanding" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DimensionBanding() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionBanding" /> class.
        /// </summary>
        /// <param name="Type">The type of banding to use (required).</param>
        /// <param name="CustomValues">If the banding type is custom, than a tab-delimited list of bands to use.</param>
        public DimensionBanding(TypeEnum Type = default(TypeEnum), string CustomValues = default(string))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for DimensionBanding and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.CustomValues = CustomValues;
        }
        

        /// <summary>
        /// If the banding type is custom, than a tab-delimited list of bands to use
        /// </summary>
        /// <value>If the banding type is custom, than a tab-delimited list of bands to use</value>
        [DataMember(Name="customValues", EmitDefaultValue=false)]
        public string CustomValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DimensionBanding {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CustomValues: ").Append(CustomValues).Append("\n");
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
            return this.Equals(input as DimensionBanding);
        }

        /// <summary>
        /// Returns true if DimensionBanding instances are equal
        /// </summary>
        /// <param name="input">Instance of DimensionBanding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DimensionBanding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CustomValues == input.CustomValues ||
                    (this.CustomValues != null &&
                    this.CustomValues.Equals(input.CustomValues))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CustomValues != null)
                    hashCode = hashCode * 59 + this.CustomValues.GetHashCode();
                return hashCode;
            }
        }
    }

}
