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
    /// Summary details for how a shareable item is shared
    /// </summary>
    [DataContract]
    public partial class ShareSummary :  IEquatable<ShareSummary>
    {
        /// <summary>
        /// The type of the shareable item (collection, list, etc.)
        /// </summary>
        /// <value>The type of the shareable item (collection, list, etc.)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShareableTypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum Collection for value: Collection
            /// </summary>
            [EnumMember(Value = "Collection")]
            Collection = 2,
            
            /// <summary>
            /// Enum List for value: List
            /// </summary>
            [EnumMember(Value = "List")]
            List = 3
        }

        /// <summary>
        /// The type of the shareable item (collection, list, etc.)
        /// </summary>
        /// <value>The type of the shareable item (collection, list, etc.)</value>
        [DataMember(Name="shareableType", EmitDefaultValue=false)]
        public ShareableTypeEnum ShareableType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShareSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareSummary" /> class.
        /// </summary>
        /// <param name="Id">The id of the share (required).</param>
        /// <param name="ShareableType">The type of the shareable item (collection, list, etc.) (required).</param>
        /// <param name="ShareableId">The id of the shareable item (required).</param>
        /// <param name="ShareableTitle">The title of the shareable item (required).</param>
        /// <param name="NumberOfUsersSharedWith">The number of people the shareable item has been shared with (required).</param>
        public ShareSummary(int? Id = default(int?), ShareableTypeEnum ShareableType = default(ShareableTypeEnum), int? ShareableId = default(int?), string ShareableTitle = default(string), int? NumberOfUsersSharedWith = default(int?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ShareSummary and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "ShareableType" is required (not null)
            if (ShareableType == null)
            {
                throw new InvalidDataException("ShareableType is a required property for ShareSummary and cannot be null");
            }
            else
            {
                this.ShareableType = ShareableType;
            }
            // to ensure "ShareableId" is required (not null)
            if (ShareableId == null)
            {
                throw new InvalidDataException("ShareableId is a required property for ShareSummary and cannot be null");
            }
            else
            {
                this.ShareableId = ShareableId;
            }
            // to ensure "ShareableTitle" is required (not null)
            if (ShareableTitle == null)
            {
                throw new InvalidDataException("ShareableTitle is a required property for ShareSummary and cannot be null");
            }
            else
            {
                this.ShareableTitle = ShareableTitle;
            }
            // to ensure "NumberOfUsersSharedWith" is required (not null)
            if (NumberOfUsersSharedWith == null)
            {
                throw new InvalidDataException("NumberOfUsersSharedWith is a required property for ShareSummary and cannot be null");
            }
            else
            {
                this.NumberOfUsersSharedWith = NumberOfUsersSharedWith;
            }
        }
        
        /// <summary>
        /// The id of the share
        /// </summary>
        /// <value>The id of the share</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// The id of the shareable item
        /// </summary>
        /// <value>The id of the shareable item</value>
        [DataMember(Name="shareableId", EmitDefaultValue=false)]
        public int? ShareableId { get; set; }

        /// <summary>
        /// The title of the shareable item
        /// </summary>
        /// <value>The title of the shareable item</value>
        [DataMember(Name="shareableTitle", EmitDefaultValue=false)]
        public string ShareableTitle { get; set; }

        /// <summary>
        /// The number of people the shareable item has been shared with
        /// </summary>
        /// <value>The number of people the shareable item has been shared with</value>
        [DataMember(Name="numberOfUsersSharedWith", EmitDefaultValue=false)]
        public int? NumberOfUsersSharedWith { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ShareableType: ").Append(ShareableType).Append("\n");
            sb.Append("  ShareableId: ").Append(ShareableId).Append("\n");
            sb.Append("  ShareableTitle: ").Append(ShareableTitle).Append("\n");
            sb.Append("  NumberOfUsersSharedWith: ").Append(NumberOfUsersSharedWith).Append("\n");
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
            return this.Equals(input as ShareSummary);
        }

        /// <summary>
        /// Returns true if ShareSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ShareSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareSummary input)
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
                    this.ShareableType == input.ShareableType ||
                    (this.ShareableType != null &&
                    this.ShareableType.Equals(input.ShareableType))
                ) && 
                (
                    this.ShareableId == input.ShareableId ||
                    (this.ShareableId != null &&
                    this.ShareableId.Equals(input.ShareableId))
                ) && 
                (
                    this.ShareableTitle == input.ShareableTitle ||
                    (this.ShareableTitle != null &&
                    this.ShareableTitle.Equals(input.ShareableTitle))
                ) && 
                (
                    this.NumberOfUsersSharedWith == input.NumberOfUsersSharedWith ||
                    (this.NumberOfUsersSharedWith != null &&
                    this.NumberOfUsersSharedWith.Equals(input.NumberOfUsersSharedWith))
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
                if (this.ShareableType != null)
                    hashCode = hashCode * 59 + this.ShareableType.GetHashCode();
                if (this.ShareableId != null)
                    hashCode = hashCode * 59 + this.ShareableId.GetHashCode();
                if (this.ShareableTitle != null)
                    hashCode = hashCode * 59 + this.ShareableTitle.GetHashCode();
                if (this.NumberOfUsersSharedWith != null)
                    hashCode = hashCode * 59 + this.NumberOfUsersSharedWith.GetHashCode();
                return hashCode;
            }
        }
    }

}
