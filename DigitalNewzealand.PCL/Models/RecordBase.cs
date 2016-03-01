/*
 * DigitalNewzealand.PCL
 *
 * This file was automatically generated by APIMATIC BETA v2.0 on 03/01/2016
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
using DigitalNewzealand.PCL;

namespace DigitalNewzealand.PCL.Models
{
    public class RecordBase : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int recordId;
        private int position;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("record_id")]
        public int RecordId 
        { 
            get 
            {
                return this.recordId; 
            } 
            set 
            {
                this.recordId = value;
                onPropertyChanged("RecordId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("position")]
        public int Position 
        { 
            get 
            {
                return this.position; 
            } 
            set 
            {
                this.position = value;
                onPropertyChanged("Position");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 