/* 
 * The SMS Works API
 *
 * The SMS Works provides a low-cost, reliable SMS API for developers. Pay only for delivered texts, all failed messages are refunded.
 *
 * OpenAPI spec version: 1.1.0
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
    /// SMS Message Batch
    /// </summary>
    [DataContract]
    public partial class BatchMessage :  IEquatable<BatchMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMessage" /> class.
        /// </summary>
        /// <param name="Sender">The sender of the message. Should be no longer than 11 characters for alphanumeric or 15 characters for numeric sender ID&#39;s. No spaces or special characters. (required).</param>
        /// <param name="Destinations">Telephone numbers of each of the recipients (required).</param>
        /// <param name="Content">Message to send to the recipient (required).</param>
        /// <param name="Schedule">Date-time at which to send the batch. This is only used by the batch/schedule service. (required).</param>
        /// <param name="Tag">An identifying label for the message, which you can use to filter and report on messages you&#39;ve sent later. Ideal for campaigns..</param>
        /// <param name="Ttl">The number of minutes before the message is deleted. Optional. Omit to prevent delivery report deletion..</param>
        public BatchMessage(string Sender = default(string), List<string> Destinations = default(List<string>), string Content = default(string), string Schedule = default(string), string Tag = default(string), decimal? Ttl = default(decimal?))
        {
            // to ensure "Sender" is required (not null)
            if (Sender == null)
            {
                throw new InvalidDataException("Sender is a required property for BatchMessage and cannot be null");
            }
            else
            {
                this.Sender = Sender;
            }
            // to ensure "Destinations" is required (not null)
            if (Destinations == null)
            {
                throw new InvalidDataException("Destinations is a required property for BatchMessage and cannot be null");
            }
            else
            {
                this.Destinations = Destinations;
            }
            // to ensure "Content" is required (not null)
            if (Content == null)
            {
                throw new InvalidDataException("Content is a required property for BatchMessage and cannot be null");
            }
            else
            {
                this.Content = Content;
            }
            // to ensure "Schedule" is required (not null)
            if (Schedule == null)
            {
                throw new InvalidDataException("Schedule is a required property for BatchMessage and cannot be null");
            }
            else
            {
                this.Schedule = Schedule;
            }
            this.Tag = Tag;
            this.Ttl = Ttl;
        }
        
        /// <summary>
        /// The sender of the message. Should be no longer than 11 characters for alphanumeric or 15 characters for numeric sender ID&#39;s. No spaces or special characters.
        /// </summary>
        /// <value>The sender of the message. Should be no longer than 11 characters for alphanumeric or 15 characters for numeric sender ID&#39;s. No spaces or special characters.</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Telephone numbers of each of the recipients
        /// </summary>
        /// <value>Telephone numbers of each of the recipients</value>
        [DataMember(Name="destinations", EmitDefaultValue=false)]
        public List<string> Destinations { get; set; }

        /// <summary>
        /// Message to send to the recipient
        /// </summary>
        /// <value>Message to send to the recipient</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Date-time at which to send the batch. This is only used by the batch/schedule service.
        /// </summary>
        /// <value>Date-time at which to send the batch. This is only used by the batch/schedule service.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public string Schedule { get; set; }

        /// <summary>
        /// An identifying label for the message, which you can use to filter and report on messages you&#39;ve sent later. Ideal for campaigns.
        /// </summary>
        /// <value>An identifying label for the message, which you can use to filter and report on messages you&#39;ve sent later. Ideal for campaigns.</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The number of minutes before the message is deleted. Optional. Omit to prevent delivery report deletion.
        /// </summary>
        /// <value>The number of minutes before the message is deleted. Optional. Omit to prevent delivery report deletion.</value>
        [DataMember(Name="ttl", EmitDefaultValue=false)]
        public decimal? Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchMessage {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Destinations: ").Append(Destinations).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
                return false;

            return 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Destinations == input.Destinations ||
                    this.Destinations != null &&
                    this.Destinations.SequenceEqual(input.Destinations)
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))
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
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Destinations != null)
                    hashCode = hashCode * 59 + this.Destinations.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Ttl != null)
                    hashCode = hashCode * 59 + this.Ttl.GetHashCode();
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
