﻿using GalaSoft.MvvmLight;
using System.Text;
using System;
using SQLite;

namespace AlarmingTrafficWP8.Model
{
    [Table("LocationsUS")]
    public class LocationUS : Location
    {
        private string _LocationCity;
        private string _LocationState;
        private string _LocationZIP;



        public string LocationCity
        {
            get { return _LocationCity; }
            set
            {
                if (Set(() => LocationCity, ref _LocationCity, value))
                {
                    IsDirty = true;
                }
            }
        }

        [MaxLength(2)]
        public string LocationState
        {
            get { return _LocationState; }
            set
            {
                if (Set(() => LocationState, ref _LocationState, value))
                {
                    IsDirty = true;
                }
            }
        }

        [MaxLength(5)]
        public string LocationZIP
        {
            get { return _LocationZIP; }
            set
            {
                if (Set(() => LocationZIP, ref _LocationZIP, value))
                {
                    IsDirty = true;
                }
            }
        }


        /// <summary>
        /// Create a return string with the whole address
        /// </summary>
        [Ignore]
        public string FullAddress
        {
            get
            {
                return String.Format("{0}, {1}, {2}, {3}",
                    LocationStreetAddress, LocationCity, LocationState, LocationZIP);
            }

        }

        // Create a copy of an location to save.
        // If your object is databound, this copy is not databound.        
        public LocationUS GetCopy()
        {
            LocationUS copy = (LocationUS)this.MemberwiseClone();
            return copy;
        }
    }
}
