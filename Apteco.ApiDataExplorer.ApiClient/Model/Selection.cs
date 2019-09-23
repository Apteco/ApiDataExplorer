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
    /// Selection
    /// </summary>
    [DataContract]
    public partial class Selection :  IEquatable<Selection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Selection" /> class.
        /// </summary>
        /// <param name="AncestorCounts">AncestorCounts.</param>
        /// <param name="RecordSet">RecordSet.</param>
        /// <param name="Rule">Rule.</param>
        /// <param name="Rfv">Rfv.</param>
        /// <param name="NPer">NPer.</param>
        /// <param name="TopN">TopN.</param>
        /// <param name="Limits">Limits.</param>
        /// <param name="TableName">TableName.</param>
        /// <param name="Name">Name.</param>
        public Selection(bool? AncestorCounts = default(bool?), RecordSet RecordSet = default(RecordSet), Rule Rule = default(Rule), RFV Rfv = default(RFV), NPer NPer = default(NPer), TopN TopN = default(TopN), Limits Limits = default(Limits), string TableName = default(string), string Name = default(string))
        {
            this.AncestorCounts = AncestorCounts;
            this.RecordSet = RecordSet;
            this.Rule = Rule;
            this.Rfv = Rfv;
            this.NPer = NPer;
            this.TopN = TopN;
            this.Limits = Limits;
            this.TableName = TableName;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets AncestorCounts
        /// </summary>
        [DataMember(Name="ancestorCounts", EmitDefaultValue=false)]
        public bool? AncestorCounts { get; set; }

        /// <summary>
        /// Gets or Sets RecordSet
        /// </summary>
        [DataMember(Name="recordSet", EmitDefaultValue=false)]
        public RecordSet RecordSet { get; set; }

        /// <summary>
        /// Gets or Sets Rule
        /// </summary>
        [DataMember(Name="rule", EmitDefaultValue=false)]
        public Rule Rule { get; set; }

        /// <summary>
        /// Gets or Sets Rfv
        /// </summary>
        [DataMember(Name="rfv", EmitDefaultValue=false)]
        public RFV Rfv { get; set; }

        /// <summary>
        /// Gets or Sets NPer
        /// </summary>
        [DataMember(Name="nPer", EmitDefaultValue=false)]
        public NPer NPer { get; set; }

        /// <summary>
        /// Gets or Sets TopN
        /// </summary>
        [DataMember(Name="topN", EmitDefaultValue=false)]
        public TopN TopN { get; set; }

        /// <summary>
        /// Gets or Sets Limits
        /// </summary>
        [DataMember(Name="limits", EmitDefaultValue=false)]
        public Limits Limits { get; set; }

        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Selection {\n");
            sb.Append("  AncestorCounts: ").Append(AncestorCounts).Append("\n");
            sb.Append("  RecordSet: ").Append(RecordSet).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
            sb.Append("  Rfv: ").Append(Rfv).Append("\n");
            sb.Append("  NPer: ").Append(NPer).Append("\n");
            sb.Append("  TopN: ").Append(TopN).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Selection);
        }

        /// <summary>
        /// Returns true if Selection instances are equal
        /// </summary>
        /// <param name="input">Instance of Selection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Selection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AncestorCounts == input.AncestorCounts ||
                    (this.AncestorCounts != null &&
                    this.AncestorCounts.Equals(input.AncestorCounts))
                ) && 
                (
                    this.RecordSet == input.RecordSet ||
                    (this.RecordSet != null &&
                    this.RecordSet.Equals(input.RecordSet))
                ) && 
                (
                    this.Rule == input.Rule ||
                    (this.Rule != null &&
                    this.Rule.Equals(input.Rule))
                ) && 
                (
                    this.Rfv == input.Rfv ||
                    (this.Rfv != null &&
                    this.Rfv.Equals(input.Rfv))
                ) && 
                (
                    this.NPer == input.NPer ||
                    (this.NPer != null &&
                    this.NPer.Equals(input.NPer))
                ) && 
                (
                    this.TopN == input.TopN ||
                    (this.TopN != null &&
                    this.TopN.Equals(input.TopN))
                ) && 
                (
                    this.Limits == input.Limits ||
                    (this.Limits != null &&
                    this.Limits.Equals(input.Limits))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.AncestorCounts != null)
                    hashCode = hashCode * 59 + this.AncestorCounts.GetHashCode();
                if (this.RecordSet != null)
                    hashCode = hashCode * 59 + this.RecordSet.GetHashCode();
                if (this.Rule != null)
                    hashCode = hashCode * 59 + this.Rule.GetHashCode();
                if (this.Rfv != null)
                    hashCode = hashCode * 59 + this.Rfv.GetHashCode();
                if (this.NPer != null)
                    hashCode = hashCode * 59 + this.NPer.GetHashCode();
                if (this.TopN != null)
                    hashCode = hashCode * 59 + this.TopN.GetHashCode();
                if (this.Limits != null)
                    hashCode = hashCode * 59 + this.Limits.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }

}
