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
    public partial class Settings :  IEquatable<Settings>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// Initializes a new instance of the <see cref="Settings" />class.
        /// </summary>
        /// <param name="Footer">Footer (default to true).</param>
        /// <param name="Clicktrack">Clicktrack (default to true).</param>
        /// <param name="Opentrack">Opentrack (default to true).</param>
        /// <param name="Unsubscribe">Unsubscribe (default to true).</param>
        /// <param name="Bcc">Bcc.</param>
        /// <param name="Attachmentid">Attachmentid.</param>
        /// <param name="Template">Template.</param>

        public Settings(bool? Footer = null, bool? Clicktrack = null, bool? Opentrack = null, bool? Unsubscribe = null, string Bcc = null, string Attachmentid = null, long? Template = null)
        {
            // use default value if no "Footer" provided
            if (Footer == null)
            {
                this.Footer = true;
            }
            else
            {
                this.Footer = Footer;
            }
            // use default value if no "Clicktrack" provided
            if (Clicktrack == null)
            {
                this.Clicktrack = true;
            }
            else
            {
                this.Clicktrack = Clicktrack;
            }
            // use default value if no "Opentrack" provided
            if (Opentrack == null)
            {
                this.Opentrack = true;
            }
            else
            {
                this.Opentrack = Opentrack;
            }
            // use default value if no "Unsubscribe" provided
            if (Unsubscribe == null)
            {
                this.Unsubscribe = true;
            }
            else
            {
                this.Unsubscribe = Unsubscribe;
            }
            this.Bcc = Bcc;
            this.Attachmentid = Attachmentid;
            this.Template = Template;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Footer
        /// </summary>
        [DataMember(Name="footer", EmitDefaultValue=false)]
        public bool? Footer { get; set; }
    
        /// <summary>
        /// Gets or Sets Clicktrack
        /// </summary>
        [DataMember(Name="clicktrack", EmitDefaultValue=false)]
        public bool? Clicktrack { get; set; }
    
        /// <summary>
        /// Gets or Sets Opentrack
        /// </summary>
        [DataMember(Name="opentrack", EmitDefaultValue=false)]
        public bool? Opentrack { get; set; }
    
        /// <summary>
        /// Gets or Sets Unsubscribe
        /// </summary>
        [DataMember(Name="unsubscribe", EmitDefaultValue=false)]
        public bool? Unsubscribe { get; set; }
    
        /// <summary>
        /// Gets or Sets Bcc
        /// </summary>
        [DataMember(Name="bcc", EmitDefaultValue=false)]
        public string Bcc { get; set; }
    
        /// <summary>
        /// Gets or Sets Attachmentid
        /// </summary>
        [DataMember(Name="attachmentid", EmitDefaultValue=false)]
        public string Attachmentid { get; set; }
    
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public long? Template { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Settings {\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
            sb.Append("  Clicktrack: ").Append(Clicktrack).Append("\n");
            sb.Append("  Opentrack: ").Append(Opentrack).Append("\n");
            sb.Append("  Unsubscribe: ").Append(Unsubscribe).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Attachmentid: ").Append(Attachmentid).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            
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
            return this.Equals(obj as Settings);
        }

        /// <summary>
        /// Returns true if Settings instances are equal
        /// </summary>
        /// <param name="other">Instance of Settings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Settings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Footer == other.Footer ||
                    this.Footer != null &&
                    this.Footer.Equals(other.Footer)
                ) && 
                (
                    this.Clicktrack == other.Clicktrack ||
                    this.Clicktrack != null &&
                    this.Clicktrack.Equals(other.Clicktrack)
                ) && 
                (
                    this.Opentrack == other.Opentrack ||
                    this.Opentrack != null &&
                    this.Opentrack.Equals(other.Opentrack)
                ) && 
                (
                    this.Unsubscribe == other.Unsubscribe ||
                    this.Unsubscribe != null &&
                    this.Unsubscribe.Equals(other.Unsubscribe)
                ) && 
                (
                    this.Bcc == other.Bcc ||
                    this.Bcc != null &&
                    this.Bcc.Equals(other.Bcc)
                ) && 
                (
                    this.Attachmentid == other.Attachmentid ||
                    this.Attachmentid != null &&
                    this.Attachmentid.Equals(other.Attachmentid)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
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
                
                if (this.Footer != null)
                    hash = hash * 59 + this.Footer.GetHashCode();
                
                if (this.Clicktrack != null)
                    hash = hash * 59 + this.Clicktrack.GetHashCode();
                
                if (this.Opentrack != null)
                    hash = hash * 59 + this.Opentrack.GetHashCode();
                
                if (this.Unsubscribe != null)
                    hash = hash * 59 + this.Unsubscribe.GetHashCode();
                
                if (this.Bcc != null)
                    hash = hash * 59 + this.Bcc.GetHashCode();
                
                if (this.Attachmentid != null)
                    hash = hash * 59 + this.Attachmentid.GetHashCode();
                
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                
                return hash;
            }
        }

    }
}
