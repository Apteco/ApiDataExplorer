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
    /// Details used to modify a list for a given user
    /// </summary>
    [DataContract]
    public partial class ModifyUserList :  IEquatable<ModifyUserList>
    {
        /// <summary>
        /// The type of modification to perform.  If the type is delete or undelete, any other specified item details will be ignored
        /// </summary>
        /// <value>The type of modification to perform.  If the type is delete or undelete, any other specified item details will be ignored</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModificationTypeEnum
        {
            
            /// <summary>
            /// Enum Modify for value: Modify
            /// </summary>
            [EnumMember(Value = "Modify")]
            Modify = 1,
            
            /// <summary>
            /// Enum Delete for value: Delete
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete = 2,
            
            /// <summary>
            /// Enum Undelete for value: Undelete
            /// </summary>
            [EnumMember(Value = "Undelete")]
            Undelete = 3
        }

        /// <summary>
        /// The type of modification to perform.  If the type is delete or undelete, any other specified item details will be ignored
        /// </summary>
        /// <value>The type of modification to perform.  If the type is delete or undelete, any other specified item details will be ignored</value>
        [DataMember(Name="modificationType", EmitDefaultValue=false)]
        public ModificationTypeEnum ModificationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyUserList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModifyUserList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyUserList" /> class.
        /// </summary>
        /// <param name="List">The list to modify (required).</param>
        /// <param name="Id">The id of the item to update (required).</param>
        /// <param name="ModificationType">The type of modification to perform.  If the type is delete or undelete, any other specified item details will be ignored (required).</param>
        public ModifyUserList(ModifyUserListDetail List = default(ModifyUserListDetail), int? Id = default(int?), ModificationTypeEnum ModificationType = default(ModificationTypeEnum))
        {
            // to ensure "List" is required (not null)
            if (List == null)
            {
                throw new InvalidDataException("List is a required property for ModifyUserList and cannot be null");
            }
            else
            {
                this.List = List;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ModifyUserList and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "ModificationType" is required (not null)
            if (ModificationType == null)
            {
                throw new InvalidDataException("ModificationType is a required property for ModifyUserList and cannot be null");
            }
            else
            {
                this.ModificationType = ModificationType;
            }
        }
        
        /// <summary>
        /// The list to modify
        /// </summary>
        /// <value>The list to modify</value>
        [DataMember(Name="list", EmitDefaultValue=false)]
        public ModifyUserListDetail List { get; set; }

        /// <summary>
        /// The id of the item to update
        /// </summary>
        /// <value>The id of the item to update</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyUserList {\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ModificationType: ").Append(ModificationType).Append("\n");
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
            return this.Equals(input as ModifyUserList);
        }

        /// <summary>
        /// Returns true if ModifyUserList instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyUserList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyUserList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.List == input.List ||
                    (this.List != null &&
                    this.List.Equals(input.List))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ModificationType == input.ModificationType ||
                    (this.ModificationType != null &&
                    this.ModificationType.Equals(input.ModificationType))
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
                if (this.List != null)
                    hashCode = hashCode * 59 + this.List.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ModificationType != null)
                    hashCode = hashCode * 59 + this.ModificationType.GetHashCode();
                return hashCode;
            }
        }
    }

}
