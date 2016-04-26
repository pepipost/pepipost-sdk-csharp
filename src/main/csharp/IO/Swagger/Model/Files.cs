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
    public partial class Files :  IEquatable<Files>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Files" /> class.
        /// Initializes a new instance of the <see cref="Files" />class.
        /// </summary>
        /// <param name="ExampleAttachment1Txt">ExampleAttachment1Txt.</param>

        public Files(string ExampleAttachment1Txt = null)
        {
            this.ExampleAttachment1Txt = ExampleAttachment1Txt;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ExampleAttachment1Txt
        /// </summary>
        [DataMember(Name="example_attachment1.txt", EmitDefaultValue=false)]
        public string ExampleAttachment1Txt { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Files {\n");
            sb.Append("  ExampleAttachment1Txt: ").Append(ExampleAttachment1Txt).Append("\n");
            
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
            return this.Equals(obj as Files);
        }

        /// <summary>
        /// Returns true if Files instances are equal
        /// </summary>
        /// <param name="other">Instance of Files to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Files other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExampleAttachment1Txt == other.ExampleAttachment1Txt ||
                    this.ExampleAttachment1Txt != null &&
                    this.ExampleAttachment1Txt.Equals(other.ExampleAttachment1Txt)
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
                
                if (this.ExampleAttachment1Txt != null)
                    hash = hash * 59 + this.ExampleAttachment1Txt.GetHashCode();
                
                return hash;
            }
        }

    }
}
