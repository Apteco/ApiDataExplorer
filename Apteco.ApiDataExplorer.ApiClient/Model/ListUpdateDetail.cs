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
    /// Details for a list update
    /// </summary>
    [DataContract]
    public partial class ListUpdateDetail :  IEquatable<ListUpdateDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListUpdateDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListUpdateDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListUpdateDetail" /> class.
        /// </summary>
        /// <param name="BriefText">Notes associated with the list at the time of this update.</param>
        /// <param name="ExcludeQuery">The query rule that defines the records to exclude from this list at the time of this update.</param>
        /// <param name="IncludeQuery">The query rule that defines the records to start with when defining this list at the time of this update.</param>
        /// <param name="BodyQuery">The query rule that defines the records that will make up this list at the time of this update..</param>
        /// <param name="SelectionModifiers">A definition of how to limit the number of records selected in the nett query built from the exclude, include and body queries.</param>
        /// <param name="Id">The list update&#39;s id (required).</param>
        /// <param name="Timestamp">The timestamp of when the update happened (required).</param>
        /// <param name="User">The user that created this update (required).</param>
        /// <param name="Title">The title of the list at the time of this update (required).</param>
        /// <param name="Description">The description of the list at the time of this update (required).</param>
        /// <param name="Owner">The details of the user that owns this list at the time of this update (required).</param>
        /// <param name="IsDeleted">Whether this update set the list to be deleted or not (required).</param>
        /// <param name="ResolveTableName">The FastStats table that the list is defined against at the time of this update (required).</param>
        public ListUpdateDetail(string BriefText = default(string), Query ExcludeQuery = default(Query), Query IncludeQuery = default(Query), Query BodyQuery = default(Query), SelectionModifiers SelectionModifiers = default(SelectionModifiers), int? Id = default(int?), DateTime? Timestamp = default(DateTime?), UserDisplayDetails User = default(UserDisplayDetails), string Title = default(string), string Description = default(string), UserDisplayDetails Owner = default(UserDisplayDetails), bool? IsDeleted = default(bool?), string ResolveTableName = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ListUpdateDetail and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for ListUpdateDetail and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "User" is required (not null)
            if (User == null)
            {
                throw new InvalidDataException("User is a required property for ListUpdateDetail and cannot be null");
            }
            else
            {
                this.User = User;
            }
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for ListUpdateDetail and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for ListUpdateDetail and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Owner" is required (not null)
            if (Owner == null)
            {
                throw new InvalidDataException("Owner is a required property for ListUpdateDetail and cannot be null");
            }
            else
            {
                this.Owner = Owner;
            }
            // to ensure "IsDeleted" is required (not null)
            if (IsDeleted == null)
            {
                throw new InvalidDataException("IsDeleted is a required property for ListUpdateDetail and cannot be null");
            }
            else
            {
                this.IsDeleted = IsDeleted;
            }
            // to ensure "ResolveTableName" is required (not null)
            if (ResolveTableName == null)
            {
                throw new InvalidDataException("ResolveTableName is a required property for ListUpdateDetail and cannot be null");
            }
            else
            {
                this.ResolveTableName = ResolveTableName;
            }
            this.BriefText = BriefText;
            this.ExcludeQuery = ExcludeQuery;
            this.IncludeQuery = IncludeQuery;
            this.BodyQuery = BodyQuery;
            this.SelectionModifiers = SelectionModifiers;
        }
        
        /// <summary>
        /// Notes associated with the list at the time of this update
        /// </summary>
        /// <value>Notes associated with the list at the time of this update</value>
        [DataMember(Name="briefText", EmitDefaultValue=false)]
        public string BriefText { get; set; }

        /// <summary>
        /// The query rule that defines the records to exclude from this list at the time of this update
        /// </summary>
        /// <value>The query rule that defines the records to exclude from this list at the time of this update</value>
        [DataMember(Name="excludeQuery", EmitDefaultValue=false)]
        public Query ExcludeQuery { get; set; }

        /// <summary>
        /// The query rule that defines the records to start with when defining this list at the time of this update
        /// </summary>
        /// <value>The query rule that defines the records to start with when defining this list at the time of this update</value>
        [DataMember(Name="includeQuery", EmitDefaultValue=false)]
        public Query IncludeQuery { get; set; }

        /// <summary>
        /// The query rule that defines the records that will make up this list at the time of this update.
        /// </summary>
        /// <value>The query rule that defines the records that will make up this list at the time of this update.</value>
        [DataMember(Name="bodyQuery", EmitDefaultValue=false)]
        public Query BodyQuery { get; set; }

        /// <summary>
        /// A definition of how to limit the number of records selected in the nett query built from the exclude, include and body queries
        /// </summary>
        /// <value>A definition of how to limit the number of records selected in the nett query built from the exclude, include and body queries</value>
        [DataMember(Name="selectionModifiers", EmitDefaultValue=false)]
        public SelectionModifiers SelectionModifiers { get; set; }

        /// <summary>
        /// The list update&#39;s id
        /// </summary>
        /// <value>The list update&#39;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The timestamp of when the update happened
        /// </summary>
        /// <value>The timestamp of when the update happened</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The user that created this update
        /// </summary>
        /// <value>The user that created this update</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserDisplayDetails User { get; set; }

        /// <summary>
        /// The title of the list at the time of this update
        /// </summary>
        /// <value>The title of the list at the time of this update</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the list at the time of this update
        /// </summary>
        /// <value>The description of the list at the time of this update</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The details of the user that owns this list at the time of this update
        /// </summary>
        /// <value>The details of the user that owns this list at the time of this update</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public UserDisplayDetails Owner { get; set; }

        /// <summary>
        /// Whether this update set the list to be deleted or not
        /// </summary>
        /// <value>Whether this update set the list to be deleted or not</value>
        [DataMember(Name="isDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// The FastStats table that the list is defined against at the time of this update
        /// </summary>
        /// <value>The FastStats table that the list is defined against at the time of this update</value>
        [DataMember(Name="resolveTableName", EmitDefaultValue=false)]
        public string ResolveTableName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUpdateDetail {\n");
            sb.Append("  BriefText: ").Append(BriefText).Append("\n");
            sb.Append("  ExcludeQuery: ").Append(ExcludeQuery).Append("\n");
            sb.Append("  IncludeQuery: ").Append(IncludeQuery).Append("\n");
            sb.Append("  BodyQuery: ").Append(BodyQuery).Append("\n");
            sb.Append("  SelectionModifiers: ").Append(SelectionModifiers).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  ResolveTableName: ").Append(ResolveTableName).Append("\n");
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
            return this.Equals(input as ListUpdateDetail);
        }

        /// <summary>
        /// Returns true if ListUpdateDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ListUpdateDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListUpdateDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BriefText == input.BriefText ||
                    (this.BriefText != null &&
                    this.BriefText.Equals(input.BriefText))
                ) && 
                (
                    this.ExcludeQuery == input.ExcludeQuery ||
                    (this.ExcludeQuery != null &&
                    this.ExcludeQuery.Equals(input.ExcludeQuery))
                ) && 
                (
                    this.IncludeQuery == input.IncludeQuery ||
                    (this.IncludeQuery != null &&
                    this.IncludeQuery.Equals(input.IncludeQuery))
                ) && 
                (
                    this.BodyQuery == input.BodyQuery ||
                    (this.BodyQuery != null &&
                    this.BodyQuery.Equals(input.BodyQuery))
                ) && 
                (
                    this.SelectionModifiers == input.SelectionModifiers ||
                    (this.SelectionModifiers != null &&
                    this.SelectionModifiers.Equals(input.SelectionModifiers))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.ResolveTableName == input.ResolveTableName ||
                    (this.ResolveTableName != null &&
                    this.ResolveTableName.Equals(input.ResolveTableName))
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
                if (this.BriefText != null)
                    hashCode = hashCode * 59 + this.BriefText.GetHashCode();
                if (this.ExcludeQuery != null)
                    hashCode = hashCode * 59 + this.ExcludeQuery.GetHashCode();
                if (this.IncludeQuery != null)
                    hashCode = hashCode * 59 + this.IncludeQuery.GetHashCode();
                if (this.BodyQuery != null)
                    hashCode = hashCode * 59 + this.BodyQuery.GetHashCode();
                if (this.SelectionModifiers != null)
                    hashCode = hashCode * 59 + this.SelectionModifiers.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.ResolveTableName != null)
                    hashCode = hashCode * 59 + this.ResolveTableName.GetHashCode();
                return hashCode;
            }
        }
    }

}
