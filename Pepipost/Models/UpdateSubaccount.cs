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
    public class UpdateSubaccount : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string username;
        private string newEmail;
        private string newPassword;
        private string confirmPassword;
        private string creditType;

        /// <summary>
        /// The username for the subaccount
        /// </summary>
        [JsonProperty("username")]
        public string Username 
        { 
            get 
            {
                return this.username; 
            } 
            set 
            {
                this.username = value;
                onPropertyChanged("Username");
            }
        }

        /// <summary>
        /// The new email address to be registered with the subaccount
        /// </summary>
        [JsonProperty("new_email")]
        public string NewEmail 
        { 
            get 
            {
                return this.newEmail; 
            } 
            set 
            {
                this.newEmail = value;
                onPropertyChanged("NewEmail");
            }
        }

        /// <summary>
        /// The new password of the subaccount
        /// </summary>
        [JsonProperty("new_password")]
        public string NewPassword 
        { 
            get 
            {
                return this.newPassword; 
            } 
            set 
            {
                this.newPassword = value;
                onPropertyChanged("NewPassword");
            }
        }

        /// <summary>
        /// reconfirm the new password for the subaccount
        /// </summary>
        [JsonProperty("confirm_password")]
        public string ConfirmPassword 
        { 
            get 
            {
                return this.confirmPassword; 
            } 
            set 
            {
                this.confirmPassword = value;
                onPropertyChanged("ConfirmPassword");
            }
        }

        /// <summary>
        /// Allowed values one_time_credit or unlimited by default, all subaccounts are created with credit type as unlimited.
        /// </summary>
        [JsonProperty("credit_type")]
        public string CreditType 
        { 
            get 
            {
                return this.creditType; 
            } 
            set 
            {
                this.creditType = value;
                onPropertyChanged("CreditType");
            }
        }
    }
} 