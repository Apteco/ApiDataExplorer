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
    /// A map between a response type and its response statistics data
    /// </summary>
    [DataContract]
    public partial class ResponseStatisticsPerResponseTypeStatisticsMap :  IEquatable<ResponseStatisticsPerResponseTypeStatisticsMap>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStatisticsPerResponseTypeStatisticsMap" /> class.
        /// </summary>
        /// <param name="Unknown">Unknown.</param>
        /// <param name="BroadcastBounce">BroadcastBounce.</param>
        /// <param name="BroadcastOpen">BroadcastOpen.</param>
        /// <param name="BroadcastClick">BroadcastClick.</param>
        /// <param name="BroadcastReply">BroadcastReply.</param>
        /// <param name="BroadcastOptIn">BroadcastOptIn.</param>
        /// <param name="BroadcastOptOut">BroadcastOptOut.</param>
        /// <param name="BroadcastDelivered">BroadcastDelivered.</param>
        /// <param name="BroadcastFailed">BroadcastFailed.</param>
        /// <param name="FacebookLike">FacebookLike.</param>
        /// <param name="FacebookComment">FacebookComment.</param>
        /// <param name="FacebookShare">FacebookShare.</param>
        /// <param name="FacebookLinkClick">FacebookLinkClick.</param>
        /// <param name="TwitterLike">TwitterLike.</param>
        /// <param name="TwitterRetweet">TwitterRetweet.</param>
        public ResponseStatisticsPerResponseTypeStatisticsMap(PerResponseTypeStatistics Unknown = default(PerResponseTypeStatistics), PerResponseTypeStatistics BroadcastBounce = default(PerResponseTypeStatistics), PerResponseTypeStatistics BroadcastOpen = default(PerResponseTypeStatistics), PerResponseTypeStatistics BroadcastClick = default(PerResponseTypeStatistics), PerResponseTypeStatistics BroadcastReply = default(PerResponseTypeStatistics), PerResponseTypeStatistics BroadcastOptIn = default(PerResponseTypeStatistics), PerResponseTypeStatistics BroadcastOptOut = default(PerResponseTypeStatistics), PerResponseTypeStatistics BroadcastDelivered = default(PerResponseTypeStatistics), PerResponseTypeStatistics BroadcastFailed = default(PerResponseTypeStatistics), PerResponseTypeStatistics FacebookLike = default(PerResponseTypeStatistics), PerResponseTypeStatistics FacebookComment = default(PerResponseTypeStatistics), PerResponseTypeStatistics FacebookShare = default(PerResponseTypeStatistics), PerResponseTypeStatistics FacebookLinkClick = default(PerResponseTypeStatistics), PerResponseTypeStatistics TwitterLike = default(PerResponseTypeStatistics), PerResponseTypeStatistics TwitterRetweet = default(PerResponseTypeStatistics))
        {
            this.Unknown = Unknown;
            this.BroadcastBounce = BroadcastBounce;
            this.BroadcastOpen = BroadcastOpen;
            this.BroadcastClick = BroadcastClick;
            this.BroadcastReply = BroadcastReply;
            this.BroadcastOptIn = BroadcastOptIn;
            this.BroadcastOptOut = BroadcastOptOut;
            this.BroadcastDelivered = BroadcastDelivered;
            this.BroadcastFailed = BroadcastFailed;
            this.FacebookLike = FacebookLike;
            this.FacebookComment = FacebookComment;
            this.FacebookShare = FacebookShare;
            this.FacebookLinkClick = FacebookLinkClick;
            this.TwitterLike = TwitterLike;
            this.TwitterRetweet = TwitterRetweet;
        }
        
        /// <summary>
        /// Gets or Sets Unknown
        /// </summary>
        [DataMember(Name="Unknown", EmitDefaultValue=false)]
        public PerResponseTypeStatistics Unknown { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastBounce
        /// </summary>
        [DataMember(Name="BroadcastBounce", EmitDefaultValue=false)]
        public PerResponseTypeStatistics BroadcastBounce { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastOpen
        /// </summary>
        [DataMember(Name="BroadcastOpen", EmitDefaultValue=false)]
        public PerResponseTypeStatistics BroadcastOpen { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastClick
        /// </summary>
        [DataMember(Name="BroadcastClick", EmitDefaultValue=false)]
        public PerResponseTypeStatistics BroadcastClick { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastReply
        /// </summary>
        [DataMember(Name="BroadcastReply", EmitDefaultValue=false)]
        public PerResponseTypeStatistics BroadcastReply { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastOptIn
        /// </summary>
        [DataMember(Name="BroadcastOptIn", EmitDefaultValue=false)]
        public PerResponseTypeStatistics BroadcastOptIn { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastOptOut
        /// </summary>
        [DataMember(Name="BroadcastOptOut", EmitDefaultValue=false)]
        public PerResponseTypeStatistics BroadcastOptOut { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastDelivered
        /// </summary>
        [DataMember(Name="BroadcastDelivered", EmitDefaultValue=false)]
        public PerResponseTypeStatistics BroadcastDelivered { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastFailed
        /// </summary>
        [DataMember(Name="BroadcastFailed", EmitDefaultValue=false)]
        public PerResponseTypeStatistics BroadcastFailed { get; set; }

        /// <summary>
        /// Gets or Sets FacebookLike
        /// </summary>
        [DataMember(Name="FacebookLike", EmitDefaultValue=false)]
        public PerResponseTypeStatistics FacebookLike { get; set; }

        /// <summary>
        /// Gets or Sets FacebookComment
        /// </summary>
        [DataMember(Name="FacebookComment", EmitDefaultValue=false)]
        public PerResponseTypeStatistics FacebookComment { get; set; }

        /// <summary>
        /// Gets or Sets FacebookShare
        /// </summary>
        [DataMember(Name="FacebookShare", EmitDefaultValue=false)]
        public PerResponseTypeStatistics FacebookShare { get; set; }

        /// <summary>
        /// Gets or Sets FacebookLinkClick
        /// </summary>
        [DataMember(Name="FacebookLinkClick", EmitDefaultValue=false)]
        public PerResponseTypeStatistics FacebookLinkClick { get; set; }

        /// <summary>
        /// Gets or Sets TwitterLike
        /// </summary>
        [DataMember(Name="TwitterLike", EmitDefaultValue=false)]
        public PerResponseTypeStatistics TwitterLike { get; set; }

        /// <summary>
        /// Gets or Sets TwitterRetweet
        /// </summary>
        [DataMember(Name="TwitterRetweet", EmitDefaultValue=false)]
        public PerResponseTypeStatistics TwitterRetweet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseStatisticsPerResponseTypeStatisticsMap {\n");
            sb.Append("  Unknown: ").Append(Unknown).Append("\n");
            sb.Append("  BroadcastBounce: ").Append(BroadcastBounce).Append("\n");
            sb.Append("  BroadcastOpen: ").Append(BroadcastOpen).Append("\n");
            sb.Append("  BroadcastClick: ").Append(BroadcastClick).Append("\n");
            sb.Append("  BroadcastReply: ").Append(BroadcastReply).Append("\n");
            sb.Append("  BroadcastOptIn: ").Append(BroadcastOptIn).Append("\n");
            sb.Append("  BroadcastOptOut: ").Append(BroadcastOptOut).Append("\n");
            sb.Append("  BroadcastDelivered: ").Append(BroadcastDelivered).Append("\n");
            sb.Append("  BroadcastFailed: ").Append(BroadcastFailed).Append("\n");
            sb.Append("  FacebookLike: ").Append(FacebookLike).Append("\n");
            sb.Append("  FacebookComment: ").Append(FacebookComment).Append("\n");
            sb.Append("  FacebookShare: ").Append(FacebookShare).Append("\n");
            sb.Append("  FacebookLinkClick: ").Append(FacebookLinkClick).Append("\n");
            sb.Append("  TwitterLike: ").Append(TwitterLike).Append("\n");
            sb.Append("  TwitterRetweet: ").Append(TwitterRetweet).Append("\n");
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
            return this.Equals(input as ResponseStatisticsPerResponseTypeStatisticsMap);
        }

        /// <summary>
        /// Returns true if ResponseStatisticsPerResponseTypeStatisticsMap instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseStatisticsPerResponseTypeStatisticsMap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseStatisticsPerResponseTypeStatisticsMap input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Unknown == input.Unknown ||
                    (this.Unknown != null &&
                    this.Unknown.Equals(input.Unknown))
                ) && 
                (
                    this.BroadcastBounce == input.BroadcastBounce ||
                    (this.BroadcastBounce != null &&
                    this.BroadcastBounce.Equals(input.BroadcastBounce))
                ) && 
                (
                    this.BroadcastOpen == input.BroadcastOpen ||
                    (this.BroadcastOpen != null &&
                    this.BroadcastOpen.Equals(input.BroadcastOpen))
                ) && 
                (
                    this.BroadcastClick == input.BroadcastClick ||
                    (this.BroadcastClick != null &&
                    this.BroadcastClick.Equals(input.BroadcastClick))
                ) && 
                (
                    this.BroadcastReply == input.BroadcastReply ||
                    (this.BroadcastReply != null &&
                    this.BroadcastReply.Equals(input.BroadcastReply))
                ) && 
                (
                    this.BroadcastOptIn == input.BroadcastOptIn ||
                    (this.BroadcastOptIn != null &&
                    this.BroadcastOptIn.Equals(input.BroadcastOptIn))
                ) && 
                (
                    this.BroadcastOptOut == input.BroadcastOptOut ||
                    (this.BroadcastOptOut != null &&
                    this.BroadcastOptOut.Equals(input.BroadcastOptOut))
                ) && 
                (
                    this.BroadcastDelivered == input.BroadcastDelivered ||
                    (this.BroadcastDelivered != null &&
                    this.BroadcastDelivered.Equals(input.BroadcastDelivered))
                ) && 
                (
                    this.BroadcastFailed == input.BroadcastFailed ||
                    (this.BroadcastFailed != null &&
                    this.BroadcastFailed.Equals(input.BroadcastFailed))
                ) && 
                (
                    this.FacebookLike == input.FacebookLike ||
                    (this.FacebookLike != null &&
                    this.FacebookLike.Equals(input.FacebookLike))
                ) && 
                (
                    this.FacebookComment == input.FacebookComment ||
                    (this.FacebookComment != null &&
                    this.FacebookComment.Equals(input.FacebookComment))
                ) && 
                (
                    this.FacebookShare == input.FacebookShare ||
                    (this.FacebookShare != null &&
                    this.FacebookShare.Equals(input.FacebookShare))
                ) && 
                (
                    this.FacebookLinkClick == input.FacebookLinkClick ||
                    (this.FacebookLinkClick != null &&
                    this.FacebookLinkClick.Equals(input.FacebookLinkClick))
                ) && 
                (
                    this.TwitterLike == input.TwitterLike ||
                    (this.TwitterLike != null &&
                    this.TwitterLike.Equals(input.TwitterLike))
                ) && 
                (
                    this.TwitterRetweet == input.TwitterRetweet ||
                    (this.TwitterRetweet != null &&
                    this.TwitterRetweet.Equals(input.TwitterRetweet))
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
                if (this.Unknown != null)
                    hashCode = hashCode * 59 + this.Unknown.GetHashCode();
                if (this.BroadcastBounce != null)
                    hashCode = hashCode * 59 + this.BroadcastBounce.GetHashCode();
                if (this.BroadcastOpen != null)
                    hashCode = hashCode * 59 + this.BroadcastOpen.GetHashCode();
                if (this.BroadcastClick != null)
                    hashCode = hashCode * 59 + this.BroadcastClick.GetHashCode();
                if (this.BroadcastReply != null)
                    hashCode = hashCode * 59 + this.BroadcastReply.GetHashCode();
                if (this.BroadcastOptIn != null)
                    hashCode = hashCode * 59 + this.BroadcastOptIn.GetHashCode();
                if (this.BroadcastOptOut != null)
                    hashCode = hashCode * 59 + this.BroadcastOptOut.GetHashCode();
                if (this.BroadcastDelivered != null)
                    hashCode = hashCode * 59 + this.BroadcastDelivered.GetHashCode();
                if (this.BroadcastFailed != null)
                    hashCode = hashCode * 59 + this.BroadcastFailed.GetHashCode();
                if (this.FacebookLike != null)
                    hashCode = hashCode * 59 + this.FacebookLike.GetHashCode();
                if (this.FacebookComment != null)
                    hashCode = hashCode * 59 + this.FacebookComment.GetHashCode();
                if (this.FacebookShare != null)
                    hashCode = hashCode * 59 + this.FacebookShare.GetHashCode();
                if (this.FacebookLinkClick != null)
                    hashCode = hashCode * 59 + this.FacebookLinkClick.GetHashCode();
                if (this.TwitterLike != null)
                    hashCode = hashCode * 59 + this.TwitterLike.GetHashCode();
                if (this.TwitterRetweet != null)
                    hashCode = hashCode * 59 + this.TwitterRetweet.GetHashCode();
                return hashCode;
            }
        }
    }

}
