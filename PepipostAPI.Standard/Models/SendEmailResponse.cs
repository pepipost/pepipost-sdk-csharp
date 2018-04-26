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
    public class SendEmailResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private object data;
        private object message;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("data")]
        public object Data 
        { 
            get 
            {
                return this.data; 
            } 
            set 
            {
                this.data = value;
                onPropertyChanged("Data");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("message")]
        public object Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }
    }
} 