﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TQ.Geocoding.DataLoad.Models.Classes
{
    public class Organisation
    {
        [Required]
        public short RecordIdentifier { get; set; }
        [Required]
        public char ChangeType { get; set; }
        [Required]
        public long ProOrder { get; set; }
        [Required]
        public long Uprn { get; set; } // FOREIGN KEY
        [Required]
        [StringLength(14)]
        public string OrgKey { get; set; } // PRIMARY KEY
        [Required]
        [StringLength(100)]
        public string OrganisationName { get; set; } // Organisation
        [StringLength(60)]
        public string LegalName { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required]
        public DateTime LastUpdateDate { get; set; }
        [Required]
        public DateTime EntryDate { get; set; }
        [Required]
        public int LoadId { get; set; }
        public BasicLandAndPropertyUnit BasicLandAndPropertyUnit { get; set; }
    }
}
