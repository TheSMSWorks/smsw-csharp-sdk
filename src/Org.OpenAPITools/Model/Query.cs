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
    /// search parameters for querying the message database
    /// </summary>
    [DataContract(Name = "Query")]
    public partial class Query : IEquatable<Query>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Query" /> class.
        /// </summary>
        /// <param name="status">The status of the messages you would like returned (either &#39;SENT&#39;, &#39;DELIVERED&#39;, &#39;EXPIRED&#39;, &#39;UNDELIVERABLE&#39;, &#39;REJECTED&#39; or &#39;INCOMING&#39;).</param>
        /// <param name="credits">The number of credits used on the message. Floating point number..</param>
        /// <param name="destination">The phone number of the recipient. Start UK numbers with 44 and drop the leading 0..</param>
        /// <param name="sender">The sender of the message (this can be the configured sender name for an outbound message or the senders phone number for an inbound message)..</param>
        /// <param name="keyword">The keyword used in the inbound message.</param>
        /// <param name="from">The date-time from which you would like matching messages.</param>
        /// <param name="to">The date-time to which you would like matching messages.</param>
        /// <param name="limit">The maximum number of messages that you would like returned in this call. The default is 1000..</param>
        /// <param name="skip">The number of results you would like to ignore before returning messages. In combination with the &#39;limit&#39; parameter his can be used to page results, so that you can deal with a limited number in your logic at each time..</param>
        /// <param name="unread">In queries for incoming messages (&#39;status&#39; is &#39;INCOMING&#39;), specify whether you explicitly want unread messages (true) or read messages (false). Omit this parameter in other circumstances..</param>
        /// <param name="metadata">metadata.</param>
        public Query(string status = default(string), decimal credits = default(decimal), string destination = default(string), string sender = default(string), string keyword = default(string), string from = default(string), string to = default(string), decimal limit = default(decimal), decimal skip = default(decimal), bool unread = default(bool), QueryMetadata metadata = default(QueryMetadata))
        {
            this.Status = status;
            this.Credits = credits;
            this.Destination = destination;
            this.Sender = sender;
            this.Keyword = keyword;
            this.From = from;
            this.To = to;
            this.Limit = limit;
            this.Skip = skip;
            this.Unread = unread;
            this.Metadata = metadata;
        }

        /// <summary>
        /// The status of the messages you would like returned (either &#39;SENT&#39;, &#39;DELIVERED&#39;, &#39;EXPIRED&#39;, &#39;UNDELIVERABLE&#39;, &#39;REJECTED&#39; or &#39;INCOMING&#39;)
        /// </summary>
        /// <value>The status of the messages you would like returned (either &#39;SENT&#39;, &#39;DELIVERED&#39;, &#39;EXPIRED&#39;, &#39;UNDELIVERABLE&#39;, &#39;REJECTED&#39; or &#39;INCOMING&#39;)</value>
        /// <example>SENT</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The number of credits used on the message. Floating point number.
        /// </summary>
        /// <value>The number of credits used on the message. Floating point number.</value>
        /// <example>2</example>
        [DataMember(Name = "credits", EmitDefaultValue = false)]
        public decimal Credits { get; set; }

        /// <summary>
        /// The phone number of the recipient. Start UK numbers with 44 and drop the leading 0.
        /// </summary>
        /// <value>The phone number of the recipient. Start UK numbers with 44 and drop the leading 0.</value>
        /// <example>447777777777</example>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public string Destination { get; set; }

        /// <summary>
        /// The sender of the message (this can be the configured sender name for an outbound message or the senders phone number for an inbound message).
        /// </summary>
        /// <value>The sender of the message (this can be the configured sender name for an outbound message or the senders phone number for an inbound message).</value>
        /// <example>YourCompany</example>
        [DataMember(Name = "sender", EmitDefaultValue = false)]
        public string Sender { get; set; }

        /// <summary>
        /// The keyword used in the inbound message
        /// </summary>
        /// <value>The keyword used in the inbound message</value>
        /// <example>SKYWALKER</example>
        [DataMember(Name = "keyword", EmitDefaultValue = false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The date-time from which you would like matching messages
        /// </summary>
        /// <value>The date-time from which you would like matching messages</value>
        /// <example>Wed Jul 12 2017 20:26:28 GMT+0100 (BST)</example>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// The date-time to which you would like matching messages
        /// </summary>
        /// <value>The date-time to which you would like matching messages</value>
        /// <example>Wed Jul 19 2017 20:26:28 GMT+0100 (BST)</example>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// The maximum number of messages that you would like returned in this call. The default is 1000.
        /// </summary>
        /// <value>The maximum number of messages that you would like returned in this call. The default is 1000.</value>
        /// <example>1000</example>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public decimal Limit { get; set; }

        /// <summary>
        /// The number of results you would like to ignore before returning messages. In combination with the &#39;limit&#39; parameter his can be used to page results, so that you can deal with a limited number in your logic at each time.
        /// </summary>
        /// <value>The number of results you would like to ignore before returning messages. In combination with the &#39;limit&#39; parameter his can be used to page results, so that you can deal with a limited number in your logic at each time.</value>
        /// <example>2000</example>
        [DataMember(Name = "skip", EmitDefaultValue = false)]
        public decimal Skip { get; set; }

        /// <summary>
        /// In queries for incoming messages (&#39;status&#39; is &#39;INCOMING&#39;), specify whether you explicitly want unread messages (true) or read messages (false). Omit this parameter in other circumstances.
        /// </summary>
        /// <value>In queries for incoming messages (&#39;status&#39; is &#39;INCOMING&#39;), specify whether you explicitly want unread messages (true) or read messages (false). Omit this parameter in other circumstances.</value>
        [DataMember(Name = "unread", EmitDefaultValue = true)]
        public bool Unread { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public QueryMetadata Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Query {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Keyword: ").Append(Keyword).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Unread: ").Append(Unread).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as Query);
        }

        /// <summary>
        /// Returns true if Query instances are equal
        /// </summary>
        /// <param name="input">Instance of Query to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Query input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Keyword == input.Keyword ||
                    (this.Keyword != null &&
                    this.Keyword.Equals(input.Keyword))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.Skip == input.Skip ||
                    this.Skip.Equals(input.Skip)
                ) && 
                (
                    this.Unread == input.Unread ||
                    this.Unread.Equals(input.Unread)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Credits.GetHashCode();
                if (this.Destination != null)
                {
                    hashCode = (hashCode * 59) + this.Destination.GetHashCode();
                }
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
                }
                if (this.Keyword != null)
                {
                    hashCode = (hashCode * 59) + this.Keyword.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                hashCode = (hashCode * 59) + this.Skip.GetHashCode();
                hashCode = (hashCode * 59) + this.Unread.GetHashCode();
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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