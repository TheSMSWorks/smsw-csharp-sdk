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
    /// MessageResponse
    /// </summary>
    [DataContract]
        public partial class MessageResponse :  IEquatable<MessageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResponse" /> class.
        /// </summary>
        /// <param name="batchid">batchid.</param>
        /// <param name="content">content (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="customerid">customerid (required).</param>
        /// <param name="destination">destination (required).</param>
        /// <param name="failurereason">failurereason.</param>
        /// <param name="id">id.</param>
        /// <param name="keyword">keyword.</param>
        /// <param name="messageid">messageid (required).</param>
        /// <param name="modified">modified (required).</param>
        /// <param name="schedule">schedule (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="sender">sender (required).</param>
        /// <param name="tag">tag (required).</param>
        public MessageResponse(string batchid = default(string), string content = default(string), string created = default(string), string customerid = default(string), decimal? destination = default(decimal?), Object failurereason = default(Object), string id = default(string), string keyword = default(string), string messageid = default(string), string modified = default(string), string schedule = default(string), string status = default(string), string sender = default(string), string tag = default(string))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "customerid" is required (not null)
            if (customerid == null)
            {
                throw new InvalidDataException("customerid is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Customerid = customerid;
            }
            // to ensure "destination" is required (not null)
            if (destination == null)
            {
                throw new InvalidDataException("destination is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Destination = destination;
            }
            // to ensure "messageid" is required (not null)
            if (messageid == null)
            {
                throw new InvalidDataException("messageid is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Messageid = messageid;
            }
            // to ensure "modified" is required (not null)
            if (modified == null)
            {
                throw new InvalidDataException("modified is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Modified = modified;
            }
            // to ensure "schedule" is required (not null)
            if (schedule == null)
            {
                throw new InvalidDataException("schedule is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Schedule = schedule;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new InvalidDataException("sender is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Sender = sender;
            }
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new InvalidDataException("tag is a required property for MessageResponse and cannot be null");
            }
            else
            {
                this.Tag = tag;
            }
            this.Batchid = batchid;
            this.Failurereason = failurereason;
            this.Id = id;
            this.Keyword = keyword;
        }
        
        /// <summary>
        /// Gets or Sets Batchid
        /// </summary>
        [DataMember(Name="batchid", EmitDefaultValue=false)]
        public string Batchid { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets Customerid
        /// </summary>
        [DataMember(Name="customerid", EmitDefaultValue=false)]
        public string Customerid { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public decimal? Destination { get; set; }

        /// <summary>
        /// Gets or Sets Failurereason
        /// </summary>
        [DataMember(Name="failurereason", EmitDefaultValue=false)]
        public Object Failurereason { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Keyword
        /// </summary>
        [DataMember(Name="keyword", EmitDefaultValue=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// Gets or Sets Messageid
        /// </summary>
        [DataMember(Name="messageid", EmitDefaultValue=false)]
        public string Messageid { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public string Modified { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public string Schedule { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageResponse {\n");
            sb.Append("  Batchid: ").Append(Batchid).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Customerid: ").Append(Customerid).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Failurereason: ").Append(Failurereason).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Keyword: ").Append(Keyword).Append("\n");
            sb.Append("  Messageid: ").Append(Messageid).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(input as MessageResponse);
        }

        /// <summary>
        /// Returns true if MessageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Batchid == input.Batchid ||
                    (this.Batchid != null &&
                    this.Batchid.Equals(input.Batchid))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Customerid == input.Customerid ||
                    (this.Customerid != null &&
                    this.Customerid.Equals(input.Customerid))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Failurereason == input.Failurereason ||
                    (this.Failurereason != null &&
                    this.Failurereason.Equals(input.Failurereason))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Keyword == input.Keyword ||
                    (this.Keyword != null &&
                    this.Keyword.Equals(input.Keyword))
                ) && 
                (
                    this.Messageid == input.Messageid ||
                    (this.Messageid != null &&
                    this.Messageid.Equals(input.Messageid))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.Batchid != null)
                    hashCode = hashCode * 59 + this.Batchid.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Customerid != null)
                    hashCode = hashCode * 59 + this.Customerid.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Failurereason != null)
                    hashCode = hashCode * 59 + this.Failurereason.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Keyword != null)
                    hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                if (this.Messageid != null)
                    hashCode = hashCode * 59 + this.Messageid.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
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
