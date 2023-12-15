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
    /// Schema for the /oyp/verify method
    /// </summary>
    [DataContract(Name = "OTPVerify")]
    public partial class OTPVerify : IEquatable<OTPVerify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OTPVerify" /> class.
        /// </summary>
        /// <param name="passcode">One-Time Passcode submitted to your application.</param>
        public OTPVerify(string passcode = default(string))
        {
            this.Passcode = passcode;
        }

        /// <summary>
        /// One-Time Passcode submitted to your application
        /// </summary>
        /// <value>One-Time Passcode submitted to your application</value>
        /// <example>123456</example>
        [DataMember(Name = "passcode", EmitDefaultValue = false)]
        public string Passcode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OTPVerify {\n");
            sb.Append("  Passcode: ").Append(Passcode).Append("\n");
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
            return this.Equals(input as OTPVerify);
        }

        /// <summary>
        /// Returns true if OTPVerify instances are equal
        /// </summary>
        /// <param name="input">Instance of OTPVerify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OTPVerify input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Passcode == input.Passcode ||
                    (this.Passcode != null &&
                    this.Passcode.Equals(input.Passcode))
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
                if (this.Passcode != null)
                {
                    hashCode = (hashCode * 59) + this.Passcode.GetHashCode();
                }
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
