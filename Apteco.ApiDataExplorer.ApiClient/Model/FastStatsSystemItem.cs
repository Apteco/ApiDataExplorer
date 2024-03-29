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
    /// Details for a FastStats system item
    /// </summary>
    [DataContract]
    public partial class FastStatsSystemItem :  IEquatable<FastStatsSystemItem>
    {
        /// <summary>
        /// The type of this item
        /// </summary>
        /// <value>The type of this item</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Variable for value: Variable
            /// </summary>
            [EnumMember(Value = "Variable")]
            Variable = 1,
            
            /// <summary>
            /// Enum VarCode for value: VarCode
            /// </summary>
            [EnumMember(Value = "VarCode")]
            VarCode = 2,
            
            /// <summary>
            /// Enum Table for value: Table
            /// </summary>
            [EnumMember(Value = "Table")]
            Table = 3,
            
            /// <summary>
            /// Enum Folder for value: Folder
            /// </summary>
            [EnumMember(Value = "Folder")]
            Folder = 4
        }

        /// <summary>
        /// The type of this item
        /// </summary>
        /// <value>The type of this item</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FastStatsSystemItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FastStatsSystemItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FastStatsSystemItem" /> class.
        /// </summary>
        /// <param name="Type">The type of this item (required).</param>
        /// <param name="Variable">If this item is a variable then these are the details.  If this item is a var code then these are the details of the variable the var code belongs to..</param>
        /// <param name="VarCode">If this item is a var code then these are the details..</param>
        /// <param name="Table">If this item is a table then these are the details..</param>
        /// <param name="Folder">If this item is a folder then these are the details..</param>
        public FastStatsSystemItem(TypeEnum Type = default(TypeEnum), VariableItem Variable = default(VariableItem), VarCode VarCode = default(VarCode), TableItem Table = default(TableItem), Folder Folder = default(Folder))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for FastStatsSystemItem and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Variable = Variable;
            this.VarCode = VarCode;
            this.Table = Table;
            this.Folder = Folder;
        }
        

        /// <summary>
        /// If this item is a variable then these are the details.  If this item is a var code then these are the details of the variable the var code belongs to.
        /// </summary>
        /// <value>If this item is a variable then these are the details.  If this item is a var code then these are the details of the variable the var code belongs to.</value>
        [DataMember(Name="variable", EmitDefaultValue=false)]
        public VariableItem Variable { get; set; }

        /// <summary>
        /// If this item is a var code then these are the details.
        /// </summary>
        /// <value>If this item is a var code then these are the details.</value>
        [DataMember(Name="varCode", EmitDefaultValue=false)]
        public VarCode VarCode { get; set; }

        /// <summary>
        /// If this item is a table then these are the details.
        /// </summary>
        /// <value>If this item is a table then these are the details.</value>
        [DataMember(Name="table", EmitDefaultValue=false)]
        public TableItem Table { get; set; }

        /// <summary>
        /// If this item is a folder then these are the details.
        /// </summary>
        /// <value>If this item is a folder then these are the details.</value>
        [DataMember(Name="folder", EmitDefaultValue=false)]
        public Folder Folder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FastStatsSystemItem {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Variable: ").Append(Variable).Append("\n");
            sb.Append("  VarCode: ").Append(VarCode).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
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
            return this.Equals(input as FastStatsSystemItem);
        }

        /// <summary>
        /// Returns true if FastStatsSystemItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FastStatsSystemItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FastStatsSystemItem input)
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
                    this.Variable == input.Variable ||
                    (this.Variable != null &&
                    this.Variable.Equals(input.Variable))
                ) && 
                (
                    this.VarCode == input.VarCode ||
                    (this.VarCode != null &&
                    this.VarCode.Equals(input.VarCode))
                ) && 
                (
                    this.Table == input.Table ||
                    (this.Table != null &&
                    this.Table.Equals(input.Table))
                ) && 
                (
                    this.Folder == input.Folder ||
                    (this.Folder != null &&
                    this.Folder.Equals(input.Folder))
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
                if (this.Variable != null)
                    hashCode = hashCode * 59 + this.Variable.GetHashCode();
                if (this.VarCode != null)
                    hashCode = hashCode * 59 + this.VarCode.GetHashCode();
                if (this.Table != null)
                    hashCode = hashCode * 59 + this.Table.GetHashCode();
                if (this.Folder != null)
                    hashCode = hashCode * 59 + this.Folder.GetHashCode();
                return hashCode;
            }
        }
    }

}
