/* 
 * The SMS Works API
 *
 * The SMS Works provides a low-cost, reliable SMS API for developers. Pay only for delivered texts, all failed messages are refunded.
 *
 * OpenAPI spec version: 1.3.0
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
    /// ExtendedErrorModel
    /// </summary>
    [DataContract]
        public partial class ExtendedErrorModel : ErrorModel,  IEquatable<ExtendedErrorModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedErrorModel" /> class.
        /// </summary>
        /// <param name="errorCode">Numeric code used to identify the error. Integer. (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="permanent">permanent.</param>
        public ExtendedErrorModel(decimal? errorCode = default(decimal?), string status = default(string), bool? permanent = default(bool?), string message = default(string)) : base(message)
        {
            // to ensure "errorCode" is required (not null)
            if (errorCode == null)
            {
                throw new InvalidDataException("errorCode is a required property for ExtendedErrorModel and cannot be null");
            }
            else
            {
                this.ErrorCode = errorCode;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for ExtendedErrorModel and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.Permanent = permanent;
        }
        
        /// <summary>
        /// Numeric code used to identify the error. Integer.
        /// </summary>
        /// <value>Numeric code used to identify the error. Integer.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public decimal? ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Permanent
        /// </summary>
        [DataMember(Name="permanent", EmitDefaultValue=false)]
        public bool? Permanent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendedErrorModel {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Permanent: ").Append(Permanent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ExtendedErrorModel);
        }

        /// <summary>
        /// Returns true if ExtendedErrorModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtendedErrorModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtendedErrorModel input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.Permanent == input.Permanent ||
                    (this.Permanent != null &&
                    this.Permanent.Equals(input.Permanent))
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
                int hashCode = base.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Permanent != null)
                    hashCode = hashCode * 59 + this.Permanent.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
