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
    /// The results returned for a measure defined in the cube
    /// </summary>
    [DataContract]
    public partial class MeasureResult :  IEquatable<MeasureResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasureResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MeasureResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasureResult" /> class.
        /// </summary>
        /// <param name="Id">The id of the measure (required).</param>
        /// <param name="Rows">If the cube is a full cube then a set of rows containing a tab delimeted set of values.  The number of values in each row will be one per category in the first dimension.  If there is a second dimension then there will be one row for each category in the second dimension.  If there are three dimensions then there will be a set of rows (holding the data for all the cells in dimensions 1 and 2) for each category in dimension 3. (required).</param>
        /// <param name="Cells">If he cube is a sparse cube then there will be a set of cells, each containing a way of indexing the cell in the cube and then the value of that cell. (required).</param>
        public MeasureResult(string Id = default(string), List<string> Rows = default(List<string>), List<string> Cells = default(List<string>))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for MeasureResult and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Rows" is required (not null)
            if (Rows == null)
            {
                throw new InvalidDataException("Rows is a required property for MeasureResult and cannot be null");
            }
            else
            {
                this.Rows = Rows;
            }
            // to ensure "Cells" is required (not null)
            if (Cells == null)
            {
                throw new InvalidDataException("Cells is a required property for MeasureResult and cannot be null");
            }
            else
            {
                this.Cells = Cells;
            }
        }
        
        /// <summary>
        /// The id of the measure
        /// </summary>
        /// <value>The id of the measure</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// If the cube is a full cube then a set of rows containing a tab delimeted set of values.  The number of values in each row will be one per category in the first dimension.  If there is a second dimension then there will be one row for each category in the second dimension.  If there are three dimensions then there will be a set of rows (holding the data for all the cells in dimensions 1 and 2) for each category in dimension 3.
        /// </summary>
        /// <value>If the cube is a full cube then a set of rows containing a tab delimeted set of values.  The number of values in each row will be one per category in the first dimension.  If there is a second dimension then there will be one row for each category in the second dimension.  If there are three dimensions then there will be a set of rows (holding the data for all the cells in dimensions 1 and 2) for each category in dimension 3.</value>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public List<string> Rows { get; set; }

        /// <summary>
        /// If he cube is a sparse cube then there will be a set of cells, each containing a way of indexing the cell in the cube and then the value of that cell.
        /// </summary>
        /// <value>If he cube is a sparse cube then there will be a set of cells, each containing a way of indexing the cell in the cube and then the value of that cell.</value>
        [DataMember(Name="cells", EmitDefaultValue=false)]
        public List<string> Cells { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeasureResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
            sb.Append("  Cells: ").Append(Cells).Append("\n");
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
            return this.Equals(input as MeasureResult);
        }

        /// <summary>
        /// Returns true if MeasureResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MeasureResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeasureResult input)
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
                    this.Rows == input.Rows ||
                    this.Rows != null &&
                    this.Rows.SequenceEqual(input.Rows)
                ) && 
                (
                    this.Cells == input.Cells ||
                    this.Cells != null &&
                    this.Cells.SequenceEqual(input.Cells)
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
                if (this.Rows != null)
                    hashCode = hashCode * 59 + this.Rows.GetHashCode();
                if (this.Cells != null)
                    hashCode = hashCode * 59 + this.Cells.GetHashCode();
                return hashCode;
            }
        }
    }

}
