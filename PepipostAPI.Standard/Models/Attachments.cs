/*
 * PepipostAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PepipostAPI.Standard;
using PepipostAPI.Standard.Utilities;


namespace PepipostAPI.Standard.Models
{
    public class Attachments : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string fileContent;
        private string fileName;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fileContent")]
        public string FileContent 
        { 
            get 
            {
                return this.fileContent; 
            } 
            set 
            {
                this.fileContent = value;
                onPropertyChanged("FileContent");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fileName")]
        public string FileName 
        { 
            get 
            {
                return this.fileName; 
            } 
            set 
            {
                this.fileName = value;
                onPropertyChanged("FileName");
            }
        }
    }
} 