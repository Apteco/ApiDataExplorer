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
    /// The username associated with a given session
    /// </summary>
    [DataContract]
    public partial class SessionAndUserDetails :  IEquatable<SessionAndUserDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionAndUserDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SessionAndUserDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionAndUserDetails" /> class.
        /// </summary>
        /// <param name="User">Details of the user associated with the session (required).</param>
        /// <param name="SessionId">The id for this session (required).</param>
        public SessionAndUserDetails(UserDisplayDetails User = default(UserDisplayDetails), string SessionId = default(string))
        {
            // to ensure "User" is required (not null)
            if (User == null)
            {
                throw new InvalidDataException("User is a required property for SessionAndUserDetails and cannot be null");
            }
            else
            {
                this.User = User;
            }
            // to ensure "SessionId" is required (not null)
            if (SessionId == null)
            {
                throw new InvalidDataException("SessionId is a required property for SessionAndUserDetails and cannot be null");
            }
            else
            {
                this.SessionId = SessionId;
            }
        }
        
        /// <summary>
        /// Details of the user associated with the session
        /// </summary>
        /// <value>Details of the user associated with the session</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserDisplayDetails User { get; set; }

        /// <summary>
        /// The id for this session
        /// </summary>
        /// <value>The id for this session</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionAndUserDetails {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
            return this.Equals(input as SessionAndUserDetails);
        }

        /// <summary>
        /// Returns true if SessionAndUserDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionAndUserDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionAndUserDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
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
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                return hashCode;
            }
        }
    }

}
