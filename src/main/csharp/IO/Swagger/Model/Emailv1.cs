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
    public partial class Emailv1 :  IEquatable<Emailv1>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Emailv1" /> class.
        /// Initializes a new instance of the <see cref="Emailv1" />class.
        /// </summary>
        /// <param name="ApiKey">Your secret API Key.</param>
        /// <param name="EmailDetails">EmailDetails.</param>
        /// <param name="X_APIHEADER">X_APIHEADER.</param>
        /// <param name="Settings">Settings.</param>
        /// <param name="Recipients">Recipients.</param>
        /// <param name="Attributes">Attributes.</param>
        /// <param name="Files">Files.</param>

        public Emailv1(string ApiKey = null, EmailDetails EmailDetails = null, List<string> X_APIHEADER = null, Settings Settings = null, List<string> Recipients = null, Attributes Attributes = null, Files Files = null)
        {
            this.ApiKey = ApiKey;
            this.EmailDetails = EmailDetails;
            this.X_APIHEADER = X_APIHEADER;
            this.Settings = Settings;
            this.Recipients = Recipients;
            this.Attributes = Attributes;
            this.Files = Files;
            
        }
        
    
        /// <summary>
        /// Your secret API Key
        /// </summary>
        /// <value>Your secret API Key</value>
        [DataMember(Name="api_key", EmitDefaultValue=false)]
        public string ApiKey { get; set; }
    
        /// <summary>
        /// Gets or Sets EmailDetails
        /// </summary>
        [DataMember(Name="email_details", EmitDefaultValue=false)]
        public EmailDetails EmailDetails { get; set; }
    
        /// <summary>
        /// Gets or Sets X_APIHEADER
        /// </summary>
        [DataMember(Name="X-APIHEADER", EmitDefaultValue=false)]
        public List<string> X_APIHEADER { get; set; }
    
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public Settings Settings { get; set; }
    
        /// <summary>
        /// Gets or Sets Recipients
        /// </summary>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<string> Recipients { get; set; }
    
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Attributes Attributes { get; set; }
    
        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [DataMember(Name="files", EmitDefaultValue=false)]
        public Files Files { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Emailv1 {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  EmailDetails: ").Append(EmailDetails).Append("\n");
            sb.Append("  X_APIHEADER: ").Append(X_APIHEADER).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            
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
            return this.Equals(obj as Emailv1);
        }

        /// <summary>
        /// Returns true if Emailv1 instances are equal
        /// </summary>
        /// <param name="other">Instance of Emailv1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Emailv1 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiKey == other.ApiKey ||
                    this.ApiKey != null &&
                    this.ApiKey.Equals(other.ApiKey)
                ) && 
                (
                    this.EmailDetails == other.EmailDetails ||
                    this.EmailDetails != null &&
                    this.EmailDetails.Equals(other.EmailDetails)
                ) && 
                (
                    this.X_APIHEADER == other.X_APIHEADER ||
                    this.X_APIHEADER != null &&
                    this.X_APIHEADER.SequenceEqual(other.X_APIHEADER)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                ) && 
                (
                    this.Recipients == other.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(other.Recipients)
                ) && 
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.Equals(other.Attributes)
                ) && 
                (
                    this.Files == other.Files ||
                    this.Files != null &&
                    this.Files.Equals(other.Files)
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
                
                if (this.ApiKey != null)
                    hash = hash * 59 + this.ApiKey.GetHashCode();
                
                if (this.EmailDetails != null)
                    hash = hash * 59 + this.EmailDetails.GetHashCode();
                
                if (this.X_APIHEADER != null)
                    hash = hash * 59 + this.X_APIHEADER.GetHashCode();
                
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                
                if (this.Recipients != null)
                    hash = hash * 59 + this.Recipients.GetHashCode();
                
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                
                if (this.Files != null)
                    hash = hash * 59 + this.Files.GetHashCode();
                
                return hash;
            }
        }

    }
}
