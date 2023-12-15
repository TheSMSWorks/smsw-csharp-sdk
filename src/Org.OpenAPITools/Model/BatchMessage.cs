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
    /// SMS Message Batch
    /// </summary>
    [DataContract(Name = "BatchMessage")]
    public partial class BatchMessage : IEquatable<BatchMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMessage" /> class.
        /// </summary>
        /// <param name="sender">The sender of the message. Should be no longer than 11 characters for alphanumeric or 15 characters for numeric sender ID&#39;s. No spaces or special characters. (required).</param>
        /// <param name="destinations">Telephone numbers of each of the recipients (required).</param>
        /// <param name="content">Message to send to the recipient (required).</param>
        /// <param name="deliveryreporturl">The url to which we should POST delivery reports to for this message. If none is specified, we&#39;ll use the global delivery report URL that you&#39;ve configured on your account page..</param>
        /// <param name="schedule">Date-time at which to send the batch. This is only used by the batch/schedule service..</param>
        /// <param name="tag">An identifying label for the message, which you can use to filter and report on messages you&#39;ve sent later. Ideal for campaigns. A maximum of 280 characters..</param>
        /// <param name="ttl">The number of minutes before the delivery report is deleted. Optional. Omit to prevent delivery report deletion. Integer..</param>
        /// <param name="validity">The optional number of minutes to attempt delivery before the message is marked as EXPIRED. Optional. The default is 2880 minutes. Integer..</param>
        /// <param name="ai">Used to determine whether The SMS Works AI Optimiser should be used in the event that the message is just longer than the 1 or 2 credit boundary. This setting overrides the AI Optimiser configuration on your SMS Works account..</param>
        public BatchMessage(string sender = default(string), List<string> destinations = default(List<string>), string content = default(string), string deliveryreporturl = default(string), string schedule = default(string), string tag = default(string), decimal ttl = default(decimal), decimal validity = default(decimal), bool ai = default(bool))
        {
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new ArgumentNullException("sender is a required property for BatchMessage and cannot be null");
            }
            this.Sender = sender;
            // to ensure "destinations" is required (not null)
            if (destinations == null)
            {
                throw new ArgumentNullException("destinations is a required property for BatchMessage and cannot be null");
            }
            this.Destinations = destinations;
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for BatchMessage and cannot be null");
            }
            this.Content = content;
            this.Deliveryreporturl = deliveryreporturl;
            this.Schedule = schedule;
            this.Tag = tag;
            this.Ttl = ttl;
            this.Validity = validity;
            this.Ai = ai;
        }

        /// <summary>
        /// The sender of the message. Should be no longer than 11 characters for alphanumeric or 15 characters for numeric sender ID&#39;s. No spaces or special characters.
        /// </summary>
        /// <value>The sender of the message. Should be no longer than 11 characters for alphanumeric or 15 characters for numeric sender ID&#39;s. No spaces or special characters.</value>
        /// <example>YourCompany</example>
        [DataMember(Name = "sender", IsRequired = true, EmitDefaultValue = true)]
        public string Sender { get; set; }

        /// <summary>
        /// Telephone numbers of each of the recipients
        /// </summary>
        /// <value>Telephone numbers of each of the recipients</value>
        /// <example>[&quot;447777777777&quot;,&quot;447777777778&quot;,&quot;447777777779&quot;]</example>
        [DataMember(Name = "destinations", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Destinations { get; set; }

        /// <summary>
        /// Message to send to the recipient
        /// </summary>
        /// <value>Message to send to the recipient</value>
        /// <example>My super awesome batch message</example>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// The url to which we should POST delivery reports to for this message. If none is specified, we&#39;ll use the global delivery report URL that you&#39;ve configured on your account page.
        /// </summary>
        /// <value>The url to which we should POST delivery reports to for this message. If none is specified, we&#39;ll use the global delivery report URL that you&#39;ve configured on your account page.</value>
        /// <example>http://your.domain.com/delivery/report/path</example>
        [DataMember(Name = "deliveryreporturl", EmitDefaultValue = false)]
        public string Deliveryreporturl { get; set; }

        /// <summary>
        /// Date-time at which to send the batch. This is only used by the batch/schedule service.
        /// </summary>
        /// <value>Date-time at which to send the batch. This is only used by the batch/schedule service.</value>
        /// <example>Wed Jul 19 2017 20:26:28 GMT+0100 (BST)</example>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public string Schedule { get; set; }

        /// <summary>
        /// An identifying label for the message, which you can use to filter and report on messages you&#39;ve sent later. Ideal for campaigns. A maximum of 280 characters.
        /// </summary>
        /// <value>An identifying label for the message, which you can use to filter and report on messages you&#39;ve sent later. Ideal for campaigns. A maximum of 280 characters.</value>
        /// <example>SummerSpecial</example>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public string Tag { get; set; }

        /// <summary>
        /// The number of minutes before the delivery report is deleted. Optional. Omit to prevent delivery report deletion. Integer.
        /// </summary>
        /// <value>The number of minutes before the delivery report is deleted. Optional. Omit to prevent delivery report deletion. Integer.</value>
        /// <example>10</example>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public decimal Ttl { get; set; }

        /// <summary>
        /// The optional number of minutes to attempt delivery before the message is marked as EXPIRED. Optional. The default is 2880 minutes. Integer.
        /// </summary>
        /// <value>The optional number of minutes to attempt delivery before the message is marked as EXPIRED. Optional. The default is 2880 minutes. Integer.</value>
        /// <example>1440</example>
        [DataMember(Name = "validity", EmitDefaultValue = false)]
        public decimal Validity { get; set; }

        /// <summary>
        /// Used to determine whether The SMS Works AI Optimiser should be used in the event that the message is just longer than the 1 or 2 credit boundary. This setting overrides the AI Optimiser configuration on your SMS Works account.
        /// </summary>
        /// <value>Used to determine whether The SMS Works AI Optimiser should be used in the event that the message is just longer than the 1 or 2 credit boundary. This setting overrides the AI Optimiser configuration on your SMS Works account.</value>
        [DataMember(Name = "ai", EmitDefaultValue = true)]
        public bool Ai { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchMessage {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Destinations: ").Append(Destinations).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Deliveryreporturl: ").Append(Deliveryreporturl).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("  Ai: ").Append(Ai).Append("\n");
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
            return this.Equals(input as BatchMessage);
        }

        /// <summary>
        /// Returns true if BatchMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchMessage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Destinations == input.Destinations ||
                    this.Destinations != null &&
                    input.Destinations != null &&
                    this.Destinations.SequenceEqual(input.Destinations)
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Deliveryreporturl == input.Deliveryreporturl ||
                    (this.Deliveryreporturl != null &&
                    this.Deliveryreporturl.Equals(input.Deliveryreporturl))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
                ) && 
                (
                    this.Validity == input.Validity ||
                    this.Validity.Equals(input.Validity)
                ) && 
                (
                    this.Ai == input.Ai ||
                    this.Ai.Equals(input.Ai)
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
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
                }
                if (this.Destinations != null)
                {
                    hashCode = (hashCode * 59) + this.Destinations.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.Deliveryreporturl != null)
                {
                    hashCode = (hashCode * 59) + this.Deliveryreporturl.GetHashCode();
                }
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                if (this.Tag != null)
                {
                    hashCode = (hashCode * 59) + this.Tag.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
                hashCode = (hashCode * 59) + this.Validity.GetHashCode();
                hashCode = (hashCode * 59) + this.Ai.GetHashCode();
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
            // Validity (decimal) maximum
            if (this.Validity > (decimal)2880)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Validity, must be a value less than or equal to 2880.", new [] { "Validity" });
            }

            // Validity (decimal) minimum
            if (this.Validity < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Validity, must be a value greater than or equal to 1.", new [] { "Validity" });
            }

            yield break;
        }
    }

}