/*
 * The SMS Works API
 *
 * The SMS Works provides a low-cost, reliable SMS API for developers. Pay only for delivered texts, all failed UK messages are refunded.
 *
 * The version of the OpenAPI document: 1.9.0
 * Contact: support@thesmsworks.co.uk
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// SendMessageResponse
    /// </summary>
    [DataContract(Name = "SendMessageResponse")]
    public partial class SendMessageResponse : IEquatable<SendMessageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendMessageResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendMessageResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendMessageResponse" /> class.
        /// </summary>
        /// <param name="messageid">messageid (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="credits">The number of remaining credits on your SMS Works account. Floating point number. (required).</param>
        /// <param name="creditsUsed">The number of credits used to send the message. Floating point number. (required).</param>
        public SendMessageResponse(string messageid = default(string), string status = default(string), decimal credits = default(decimal), decimal creditsUsed = default(decimal))
        {
            // to ensure "messageid" is required (not null)
            if (messageid == null)
            {
                throw new ArgumentNullException("messageid is a required property for SendMessageResponse and cannot be null");
            }
            this.Messageid = messageid;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for SendMessageResponse and cannot be null");
            }
            this.Status = status;
            this.Credits = credits;
            this.CreditsUsed = creditsUsed;
        }

        /// <summary>
        /// Gets or Sets Messageid
        /// </summary>
        /// <example>123456789</example>
        [DataMember(Name = "messageid", IsRequired = true, EmitDefaultValue = true)]
        public string Messageid { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        /// <example>SENT</example>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// The number of remaining credits on your SMS Works account. Floating point number.
        /// </summary>
        /// <value>The number of remaining credits on your SMS Works account. Floating point number.</value>
        /// <example>180</example>
        [DataMember(Name = "credits", IsRequired = true, EmitDefaultValue = true)]
        public decimal Credits { get; set; }

        /// <summary>
        /// The number of credits used to send the message. Floating point number.
        /// </summary>
        /// <value>The number of credits used to send the message. Floating point number.</value>
        /// <example>2</example>
        [DataMember(Name = "creditsUsed", IsRequired = true, EmitDefaultValue = true)]
        public decimal CreditsUsed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SendMessageResponse {\n");
            sb.Append("  Messageid: ").Append(Messageid).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  CreditsUsed: ").Append(CreditsUsed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendMessageResponse);
        }

        /// <summary>
        /// Returns true if SendMessageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SendMessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendMessageResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Messageid == input.Messageid ||
                    (this.Messageid != null &&
                    this.Messageid.Equals(input.Messageid))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Credits == input.Credits ||
                    this.Credits.Equals(input.Credits)
                ) && 
                (
                    this.CreditsUsed == input.CreditsUsed ||
                    this.CreditsUsed.Equals(input.CreditsUsed)
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
                if (this.Messageid != null)
                {
                    hashCode = (hashCode * 59) + this.Messageid.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Credits.GetHashCode();
                hashCode = (hashCode * 59) + this.CreditsUsed.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}