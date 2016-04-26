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

namespace IO.Swagger.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class EmailDetails :  IEquatable<EmailDetails>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailDetails" /> class.
        /// Initializes a new instance of the <see cref="EmailDetails" />class.
        /// </summary>
        /// <param name="Fromname">Fromname.</param>
        /// <param name="Subject">Subject.</param>
        /// <param name="From">From.</param>
        /// <param name="Replytoid">Replytoid.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Content">Content.</param>

        public EmailDetails(string Fromname = null, string Subject = null, string From = null, string Replytoid = null, string Tags = null, string Content = null)
        {
            this.Fromname = Fromname;
            this.Subject = Subject;
            this.From = From;
            this.Replytoid = Replytoid;
            this.Tags = Tags;
            this.Content = Content;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Fromname
        /// </summary>
        [DataMember(Name="fromname", EmitDefaultValue=false)]
        public string Fromname { get; set; }
    
        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }
    
        /// <summary>
        /// Gets or Sets Replytoid
        /// </summary>
        [DataMember(Name="replytoid", EmitDefaultValue=false)]
        public string Replytoid { get; set; }
    
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public string Tags { get; set; }
    
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailDetails {\n");
            sb.Append("  Fromname: ").Append(Fromname).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Replytoid: ").Append(Replytoid).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EmailDetails);
        }

        /// <summary>
        /// Returns true if EmailDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Fromname == other.Fromname ||
                    this.Fromname != null &&
                    this.Fromname.Equals(other.Fromname)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) && 
                (
                    this.Replytoid == other.Replytoid ||
                    this.Replytoid != null &&
                    this.Replytoid.Equals(other.Replytoid)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Fromname != null)
                    hash = hash * 59 + this.Fromname.GetHashCode();
                
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                
                if (this.Replytoid != null)
                    hash = hash * 59 + this.Replytoid.GetHashCode();
                
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                
                return hash;
            }
        }

    }
}
