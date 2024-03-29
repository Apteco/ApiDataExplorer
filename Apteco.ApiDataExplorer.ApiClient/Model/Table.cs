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
    /// Details for a table in the FastStats system
    /// </summary>
    [DataContract]
    public partial class Table :  IEquatable<Table>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Table() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        /// <param name="Name">The name of the table (required).</param>
        /// <param name="SingularDisplayName">A description to use for this table when refering to a single entity (i.e. \&quot;A Person\&quot;) (required).</param>
        /// <param name="PluralDisplayName">A description to use for this table when refering to multiple entities (i.e. \&quot;Many People\&quot;) (required).</param>
        /// <param name="IsDefaultTable">Whether this table is the default table in the FastStats system or not - i.e. the table to use when creating a blank query (required).</param>
        /// <param name="IsPeopleTable">Whether this table is the one in the FastStats system used to represent natural people (required).</param>
        /// <param name="TotalRecords">The total number of records in this table (required).</param>
        /// <param name="ChildRelationshipName">A descriptive word or phrase to use when relating this table to one of its child tables (i.e. a Households \&quot;is occupied by\&quot; a Customer) (required).</param>
        /// <param name="ParentRelationshipName">A descriptive word or phrase to use when relating this table to one of its parent tables (i.e. a Customer \&quot;lives at\&quot; a Households) (required).</param>
        /// <param name="HasChildTables">Whether this table has any child tables (required).</param>
        /// <param name="ParentTable">The name of the parent table for this table.  The Master table is the only table without a parent (required).</param>
        public Table(string Name = default(string), string SingularDisplayName = default(string), string PluralDisplayName = default(string), bool? IsDefaultTable = default(bool?), bool? IsPeopleTable = default(bool?), long? TotalRecords = default(long?), string ChildRelationshipName = default(string), string ParentRelationshipName = default(string), bool? HasChildTables = default(bool?), string ParentTable = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Table and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "SingularDisplayName" is required (not null)
            if (SingularDisplayName == null)
            {
                throw new InvalidDataException("SingularDisplayName is a required property for Table and cannot be null");
            }
            else
            {
                this.SingularDisplayName = SingularDisplayName;
            }
            // to ensure "PluralDisplayName" is required (not null)
            if (PluralDisplayName == null)
            {
                throw new InvalidDataException("PluralDisplayName is a required property for Table and cannot be null");
            }
            else
            {
                this.PluralDisplayName = PluralDisplayName;
            }
            // to ensure "IsDefaultTable" is required (not null)
            if (IsDefaultTable == null)
            {
                throw new InvalidDataException("IsDefaultTable is a required property for Table and cannot be null");
            }
            else
            {
                this.IsDefaultTable = IsDefaultTable;
            }
            // to ensure "IsPeopleTable" is required (not null)
            if (IsPeopleTable == null)
            {
                throw new InvalidDataException("IsPeopleTable is a required property for Table and cannot be null");
            }
            else
            {
                this.IsPeopleTable = IsPeopleTable;
            }
            // to ensure "TotalRecords" is required (not null)
            if (TotalRecords == null)
            {
                throw new InvalidDataException("TotalRecords is a required property for Table and cannot be null");
            }
            else
            {
                this.TotalRecords = TotalRecords;
            }
            // to ensure "ChildRelationshipName" is required (not null)
            if (ChildRelationshipName == null)
            {
                throw new InvalidDataException("ChildRelationshipName is a required property for Table and cannot be null");
            }
            else
            {
                this.ChildRelationshipName = ChildRelationshipName;
            }
            // to ensure "ParentRelationshipName" is required (not null)
            if (ParentRelationshipName == null)
            {
                throw new InvalidDataException("ParentRelationshipName is a required property for Table and cannot be null");
            }
            else
            {
                this.ParentRelationshipName = ParentRelationshipName;
            }
            // to ensure "HasChildTables" is required (not null)
            if (HasChildTables == null)
            {
                throw new InvalidDataException("HasChildTables is a required property for Table and cannot be null");
            }
            else
            {
                this.HasChildTables = HasChildTables;
            }
            // to ensure "ParentTable" is required (not null)
            if (ParentTable == null)
            {
                throw new InvalidDataException("ParentTable is a required property for Table and cannot be null");
            }
            else
            {
                this.ParentTable = ParentTable;
            }
        }
        
        /// <summary>
        /// The name of the table
        /// </summary>
        /// <value>The name of the table</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A description to use for this table when refering to a single entity (i.e. \&quot;A Person\&quot;)
        /// </summary>
        /// <value>A description to use for this table when refering to a single entity (i.e. \&quot;A Person\&quot;)</value>
        [DataMember(Name="singularDisplayName", EmitDefaultValue=false)]
        public string SingularDisplayName { get; set; }

        /// <summary>
        /// A description to use for this table when refering to multiple entities (i.e. \&quot;Many People\&quot;)
        /// </summary>
        /// <value>A description to use for this table when refering to multiple entities (i.e. \&quot;Many People\&quot;)</value>
        [DataMember(Name="pluralDisplayName", EmitDefaultValue=false)]
        public string PluralDisplayName { get; set; }

        /// <summary>
        /// Whether this table is the default table in the FastStats system or not - i.e. the table to use when creating a blank query
        /// </summary>
        /// <value>Whether this table is the default table in the FastStats system or not - i.e. the table to use when creating a blank query</value>
        [DataMember(Name="isDefaultTable", EmitDefaultValue=false)]
        public bool? IsDefaultTable { get; set; }

        /// <summary>
        /// Whether this table is the one in the FastStats system used to represent natural people
        /// </summary>
        /// <value>Whether this table is the one in the FastStats system used to represent natural people</value>
        [DataMember(Name="isPeopleTable", EmitDefaultValue=false)]
        public bool? IsPeopleTable { get; set; }

        /// <summary>
        /// The total number of records in this table
        /// </summary>
        /// <value>The total number of records in this table</value>
        [DataMember(Name="totalRecords", EmitDefaultValue=false)]
        public long? TotalRecords { get; set; }

        /// <summary>
        /// A descriptive word or phrase to use when relating this table to one of its child tables (i.e. a Households \&quot;is occupied by\&quot; a Customer)
        /// </summary>
        /// <value>A descriptive word or phrase to use when relating this table to one of its child tables (i.e. a Households \&quot;is occupied by\&quot; a Customer)</value>
        [DataMember(Name="childRelationshipName", EmitDefaultValue=false)]
        public string ChildRelationshipName { get; set; }

        /// <summary>
        /// A descriptive word or phrase to use when relating this table to one of its parent tables (i.e. a Customer \&quot;lives at\&quot; a Households)
        /// </summary>
        /// <value>A descriptive word or phrase to use when relating this table to one of its parent tables (i.e. a Customer \&quot;lives at\&quot; a Households)</value>
        [DataMember(Name="parentRelationshipName", EmitDefaultValue=false)]
        public string ParentRelationshipName { get; set; }

        /// <summary>
        /// Whether this table has any child tables
        /// </summary>
        /// <value>Whether this table has any child tables</value>
        [DataMember(Name="hasChildTables", EmitDefaultValue=false)]
        public bool? HasChildTables { get; set; }

        /// <summary>
        /// The name of the parent table for this table.  The Master table is the only table without a parent
        /// </summary>
        /// <value>The name of the parent table for this table.  The Master table is the only table without a parent</value>
        [DataMember(Name="parentTable", EmitDefaultValue=false)]
        public string ParentTable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Table {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SingularDisplayName: ").Append(SingularDisplayName).Append("\n");
            sb.Append("  PluralDisplayName: ").Append(PluralDisplayName).Append("\n");
            sb.Append("  IsDefaultTable: ").Append(IsDefaultTable).Append("\n");
            sb.Append("  IsPeopleTable: ").Append(IsPeopleTable).Append("\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  ChildRelationshipName: ").Append(ChildRelationshipName).Append("\n");
            sb.Append("  ParentRelationshipName: ").Append(ParentRelationshipName).Append("\n");
            sb.Append("  HasChildTables: ").Append(HasChildTables).Append("\n");
            sb.Append("  ParentTable: ").Append(ParentTable).Append("\n");
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
            return this.Equals(input as Table);
        }

        /// <summary>
        /// Returns true if Table instances are equal
        /// </summary>
        /// <param name="input">Instance of Table to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Table input)
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
                    this.SingularDisplayName == input.SingularDisplayName ||
                    (this.SingularDisplayName != null &&
                    this.SingularDisplayName.Equals(input.SingularDisplayName))
                ) && 
                (
                    this.PluralDisplayName == input.PluralDisplayName ||
                    (this.PluralDisplayName != null &&
                    this.PluralDisplayName.Equals(input.PluralDisplayName))
                ) && 
                (
                    this.IsDefaultTable == input.IsDefaultTable ||
                    (this.IsDefaultTable != null &&
                    this.IsDefaultTable.Equals(input.IsDefaultTable))
                ) && 
                (
                    this.IsPeopleTable == input.IsPeopleTable ||
                    (this.IsPeopleTable != null &&
                    this.IsPeopleTable.Equals(input.IsPeopleTable))
                ) && 
                (
                    this.TotalRecords == input.TotalRecords ||
                    (this.TotalRecords != null &&
                    this.TotalRecords.Equals(input.TotalRecords))
                ) && 
                (
                    this.ChildRelationshipName == input.ChildRelationshipName ||
                    (this.ChildRelationshipName != null &&
                    this.ChildRelationshipName.Equals(input.ChildRelationshipName))
                ) && 
                (
                    this.ParentRelationshipName == input.ParentRelationshipName ||
                    (this.ParentRelationshipName != null &&
                    this.ParentRelationshipName.Equals(input.ParentRelationshipName))
                ) && 
                (
                    this.HasChildTables == input.HasChildTables ||
                    (this.HasChildTables != null &&
                    this.HasChildTables.Equals(input.HasChildTables))
                ) && 
                (
                    this.ParentTable == input.ParentTable ||
                    (this.ParentTable != null &&
                    this.ParentTable.Equals(input.ParentTable))
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
                if (this.SingularDisplayName != null)
                    hashCode = hashCode * 59 + this.SingularDisplayName.GetHashCode();
                if (this.PluralDisplayName != null)
                    hashCode = hashCode * 59 + this.PluralDisplayName.GetHashCode();
                if (this.IsDefaultTable != null)
                    hashCode = hashCode * 59 + this.IsDefaultTable.GetHashCode();
                if (this.IsPeopleTable != null)
                    hashCode = hashCode * 59 + this.IsPeopleTable.GetHashCode();
                if (this.TotalRecords != null)
                    hashCode = hashCode * 59 + this.TotalRecords.GetHashCode();
                if (this.ChildRelationshipName != null)
                    hashCode = hashCode * 59 + this.ChildRelationshipName.GetHashCode();
                if (this.ParentRelationshipName != null)
                    hashCode = hashCode * 59 + this.ParentRelationshipName.GetHashCode();
                if (this.HasChildTables != null)
                    hashCode = hashCode * 59 + this.HasChildTables.GetHashCode();
                if (this.ParentTable != null)
                    hashCode = hashCode * 59 + this.ParentTable.GetHashCode();
                return hashCode;
            }
        }
    }

}
