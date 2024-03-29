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
    /// Detail information for a list export
    /// </summary>
    [DataContract]
    public partial class ListExportDetail :  IEquatable<ListExportDetail>
    {
        /// <summary>
        /// If specified, the format of a file that the data was exported to
        /// </summary>
        /// <value>If specified, the format of a file that the data was exported to</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            
            /// <summary>
            /// Enum CSV for value: CSV
            /// </summary>
            [EnumMember(Value = "CSV")]
            CSV = 1,
            
            /// <summary>
            /// Enum SDF for value: SDF
            /// </summary>
            [EnumMember(Value = "SDF")]
            SDF = 2,
            
            /// <summary>
            /// Enum XLSX for value: XLSX
            /// </summary>
            [EnumMember(Value = "XLSX")]
            XLSX = 3,
            
            /// <summary>
            /// Enum MDB for value: MDB
            /// </summary>
            [EnumMember(Value = "MDB")]
            MDB = 4,
            
            /// <summary>
            /// Enum DBF for value: DBF
            /// </summary>
            [EnumMember(Value = "DBF")]
            DBF = 5,
            
            /// <summary>
            /// Enum URN for value: URN
            /// </summary>
            [EnumMember(Value = "URN")]
            URN = 6
        }

        /// <summary>
        /// If specified, the format of a file that the data was exported to
        /// </summary>
        /// <value>If specified, the format of a file that the data was exported to</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListExportDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListExportDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListExportDetail" /> class.
        /// </summary>
        /// <param name="ListUpdateId">The id of the update (list version) that the export was created from (required).</param>
        /// <param name="Timestamp">The date and time that the export was produced (required).</param>
        /// <param name="FastStatsBuildDate">The date and time that the FastStats system used to create this export was built (required).</param>
        /// <param name="User">The user that triggered the export (required).</param>
        /// <param name="NettCounts">The set of overall counts for the list behind this export (required).</param>
        /// <param name="UrnFilePath">If a URN file was generated as part of this export then this will be its path within the FastStats system (required).</param>
        /// <param name="MaximumNumberOfRowsToBrowse">The requested maximum number of rows to return when browsing the data (required).</param>
        /// <param name="ReturnBrowseRows">Whether data rows were requested to be returned or whether the data was exported directly to the specified file (required).</param>
        /// <param name="FilePath">If specified, the path of a file that the data was exported to.</param>
        /// <param name="Format">If specified, the format of a file that the data was exported to.</param>
        /// <param name="Columns">The list of columns that have been included in this export (required).</param>
        /// <param name="Rows">If data rows were requested to be returned then the set of rows containing data for the given columns selected by the list queries.</param>
        public ListExportDetail(int? ListUpdateId = default(int?), DateTime? Timestamp = default(DateTime?), DateTime? FastStatsBuildDate = default(DateTime?), UserDisplayDetails User = default(UserDisplayDetails), List<Count> NettCounts = default(List<Count>), string UrnFilePath = default(string), long? MaximumNumberOfRowsToBrowse = default(long?), bool? ReturnBrowseRows = default(bool?), string FilePath = default(string), FormatEnum? Format = default(FormatEnum?), List<Column> Columns = default(List<Column>), List<Row> Rows = default(List<Row>))
        {
            // to ensure "ListUpdateId" is required (not null)
            if (ListUpdateId == null)
            {
                throw new InvalidDataException("ListUpdateId is a required property for ListExportDetail and cannot be null");
            }
            else
            {
                this.ListUpdateId = ListUpdateId;
            }
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for ListExportDetail and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "FastStatsBuildDate" is required (not null)
            if (FastStatsBuildDate == null)
            {
                throw new InvalidDataException("FastStatsBuildDate is a required property for ListExportDetail and cannot be null");
            }
            else
            {
                this.FastStatsBuildDate = FastStatsBuildDate;
            }
            // to ensure "User" is required (not null)
            if (User == null)
            {
                throw new InvalidDataException("User is a required property for ListExportDetail and cannot be null");
            }
            else
            {
                this.User = User;
            }
            // to ensure "NettCounts" is required (not null)
            if (NettCounts == null)
            {
                throw new InvalidDataException("NettCounts is a required property for ListExportDetail and cannot be null");
            }
            else
            {
                this.NettCounts = NettCounts;
            }
            // to ensure "UrnFilePath" is required (not null)
            if (UrnFilePath == null)
            {
                throw new InvalidDataException("UrnFilePath is a required property for ListExportDetail and cannot be null");
            }
            else
            {
                this.UrnFilePath = UrnFilePath;
            }
            // to ensure "MaximumNumberOfRowsToBrowse" is required (not null)
            if (MaximumNumberOfRowsToBrowse == null)
            {
                throw new InvalidDataException("MaximumNumberOfRowsToBrowse is a required property for ListExportDetail and cannot be null");
            }
            else
            {
                this.MaximumNumberOfRowsToBrowse = MaximumNumberOfRowsToBrowse;
            }
            // to ensure "ReturnBrowseRows" is required (not null)
            if (ReturnBrowseRows == null)
            {
                throw new InvalidDataException("ReturnBrowseRows is a required property for ListExportDetail and cannot be null");
            }
            else
            {
                this.ReturnBrowseRows = ReturnBrowseRows;
            }
            // to ensure "Columns" is required (not null)
            if (Columns == null)
            {
                throw new InvalidDataException("Columns is a required property for ListExportDetail and cannot be null");
            }
            else
            {
                this.Columns = Columns;
            }
            this.FilePath = FilePath;
            this.Format = Format;
            this.Rows = Rows;
        }
        
        /// <summary>
        /// The id of the update (list version) that the export was created from
        /// </summary>
        /// <value>The id of the update (list version) that the export was created from</value>
        [DataMember(Name="listUpdateId", EmitDefaultValue=false)]
        public int? ListUpdateId { get; set; }

        /// <summary>
        /// The date and time that the export was produced
        /// </summary>
        /// <value>The date and time that the export was produced</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The date and time that the FastStats system used to create this export was built
        /// </summary>
        /// <value>The date and time that the FastStats system used to create this export was built</value>
        [DataMember(Name="fastStatsBuildDate", EmitDefaultValue=false)]
        public DateTime? FastStatsBuildDate { get; set; }

        /// <summary>
        /// The user that triggered the export
        /// </summary>
        /// <value>The user that triggered the export</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserDisplayDetails User { get; set; }

        /// <summary>
        /// The set of overall counts for the list behind this export
        /// </summary>
        /// <value>The set of overall counts for the list behind this export</value>
        [DataMember(Name="nettCounts", EmitDefaultValue=false)]
        public List<Count> NettCounts { get; set; }

        /// <summary>
        /// If a URN file was generated as part of this export then this will be its path within the FastStats system
        /// </summary>
        /// <value>If a URN file was generated as part of this export then this will be its path within the FastStats system</value>
        [DataMember(Name="urnFilePath", EmitDefaultValue=false)]
        public string UrnFilePath { get; set; }

        /// <summary>
        /// The requested maximum number of rows to return when browsing the data
        /// </summary>
        /// <value>The requested maximum number of rows to return when browsing the data</value>
        [DataMember(Name="maximumNumberOfRowsToBrowse", EmitDefaultValue=false)]
        public long? MaximumNumberOfRowsToBrowse { get; set; }

        /// <summary>
        /// Whether data rows were requested to be returned or whether the data was exported directly to the specified file
        /// </summary>
        /// <value>Whether data rows were requested to be returned or whether the data was exported directly to the specified file</value>
        [DataMember(Name="returnBrowseRows", EmitDefaultValue=false)]
        public bool? ReturnBrowseRows { get; set; }

        /// <summary>
        /// If specified, the path of a file that the data was exported to
        /// </summary>
        /// <value>If specified, the path of a file that the data was exported to</value>
        [DataMember(Name="filePath", EmitDefaultValue=false)]
        public string FilePath { get; set; }


        /// <summary>
        /// The list of columns that have been included in this export
        /// </summary>
        /// <value>The list of columns that have been included in this export</value>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<Column> Columns { get; set; }

        /// <summary>
        /// If data rows were requested to be returned then the set of rows containing data for the given columns selected by the list queries
        /// </summary>
        /// <value>If data rows were requested to be returned then the set of rows containing data for the given columns selected by the list queries</value>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public List<Row> Rows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListExportDetail {\n");
            sb.Append("  ListUpdateId: ").Append(ListUpdateId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  FastStatsBuildDate: ").Append(FastStatsBuildDate).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  NettCounts: ").Append(NettCounts).Append("\n");
            sb.Append("  UrnFilePath: ").Append(UrnFilePath).Append("\n");
            sb.Append("  MaximumNumberOfRowsToBrowse: ").Append(MaximumNumberOfRowsToBrowse).Append("\n");
            sb.Append("  ReturnBrowseRows: ").Append(ReturnBrowseRows).Append("\n");
            sb.Append("  FilePath: ").Append(FilePath).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
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
            return this.Equals(input as ListExportDetail);
        }

        /// <summary>
        /// Returns true if ListExportDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ListExportDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListExportDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListUpdateId == input.ListUpdateId ||
                    (this.ListUpdateId != null &&
                    this.ListUpdateId.Equals(input.ListUpdateId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.FastStatsBuildDate == input.FastStatsBuildDate ||
                    (this.FastStatsBuildDate != null &&
                    this.FastStatsBuildDate.Equals(input.FastStatsBuildDate))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.NettCounts == input.NettCounts ||
                    this.NettCounts != null &&
                    this.NettCounts.SequenceEqual(input.NettCounts)
                ) && 
                (
                    this.UrnFilePath == input.UrnFilePath ||
                    (this.UrnFilePath != null &&
                    this.UrnFilePath.Equals(input.UrnFilePath))
                ) && 
                (
                    this.MaximumNumberOfRowsToBrowse == input.MaximumNumberOfRowsToBrowse ||
                    (this.MaximumNumberOfRowsToBrowse != null &&
                    this.MaximumNumberOfRowsToBrowse.Equals(input.MaximumNumberOfRowsToBrowse))
                ) && 
                (
                    this.ReturnBrowseRows == input.ReturnBrowseRows ||
                    (this.ReturnBrowseRows != null &&
                    this.ReturnBrowseRows.Equals(input.ReturnBrowseRows))
                ) && 
                (
                    this.FilePath == input.FilePath ||
                    (this.FilePath != null &&
                    this.FilePath.Equals(input.FilePath))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Columns == input.Columns ||
                    this.Columns != null &&
                    this.Columns.SequenceEqual(input.Columns)
                ) && 
                (
                    this.Rows == input.Rows ||
                    this.Rows != null &&
                    this.Rows.SequenceEqual(input.Rows)
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
                if (this.ListUpdateId != null)
                    hashCode = hashCode * 59 + this.ListUpdateId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.FastStatsBuildDate != null)
                    hashCode = hashCode * 59 + this.FastStatsBuildDate.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.NettCounts != null)
                    hashCode = hashCode * 59 + this.NettCounts.GetHashCode();
                if (this.UrnFilePath != null)
                    hashCode = hashCode * 59 + this.UrnFilePath.GetHashCode();
                if (this.MaximumNumberOfRowsToBrowse != null)
                    hashCode = hashCode * 59 + this.MaximumNumberOfRowsToBrowse.GetHashCode();
                if (this.ReturnBrowseRows != null)
                    hashCode = hashCode * 59 + this.ReturnBrowseRows.GetHashCode();
                if (this.FilePath != null)
                    hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
                if (this.Rows != null)
                    hashCode = hashCode * 59 + this.Rows.GetHashCode();
                return hashCode;
            }
        }
    }

}
