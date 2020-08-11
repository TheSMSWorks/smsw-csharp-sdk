/* 
 * The SMS Works API
 *
 * The SMS Works provides a low-cost, reliable SMS API for developers. Pay only for delivered texts, all failed messages are refunded.
 *
 * OpenAPI spec version: 1.4.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// CancelledMessageResponse
    /// </summary>
    [DataContract]
        public partial class CancelledMessageResponse :  IEquatable<CancelledMessageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelledMessageResponse" /> class.
        /// </summary>
        /// <param name="messageid">messageid (required).</param>
        /// <param name="status">status (required).</param>
        public CancelledMessageResponse(string messageid = default(string), string status = default(string))
        {
            // to ensure "messageid" is required (not null)
            if (messageid == null)
            {
                throw new InvalidDataException("messageid is a required property for CancelledMessageResponse and cannot be null");
            }
            else
            {
                this.Messageid = messageid;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for CancelledMessageResponse and cannot be null");
            }
            else
            {
                this.Status = status;
            }
        }
        
        /// <summary>
        /// Gets or Sets Messageid
        /// </summary>
        [DataMember(Name="messageid", EmitDefaultValue=false)]
        public string Messageid { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelledMessageResponse {\n");
            sb.Append("  Messageid: ").Append(Messageid).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as CancelledMessageResponse);
        }

        /// <summary>
        /// Returns true if CancelledMessageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelledMessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelledMessageResponse input)
        {
            if (input == null)
                return false;

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
                    hashCode = hashCode * 59 + this.Messageid.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
