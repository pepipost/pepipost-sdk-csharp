/*
 * Pepipost
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
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
using Pepipost;
using Pepipost.Utilities;


namespace Pepipost.Models
{
    public class RemoveEmailOrDomainToSuppressionList : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string domain;
        private string email;

        /// <summary>
        /// List one or more recipient domains to be removed from the suppression list here. <br>\nComma separate the values to suppress multiple recipient domains.
        /// </summary>
        [JsonProperty("domain")]
        public string Domain 
        { 
            get 
            {
                return this.domain; 
            } 
            set 
            {
                this.domain = value;
                onPropertyChanged("Domain");
            }
        }

        /// <summary>
        /// List one or more email addresses to be removed from the suppression list here. <br>\nComma separate the values to suppress multiple email addresses.
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }
    }
} 