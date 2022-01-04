﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneTrackerOnline.Models
{
    public class TargetPhone
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        public int OldCode { get; set; }

        [Required]
        public bool IsAlreadyTaken { get; set; }

        /*[ForeignKey("Contact")]
        public int ContactID { get; set; }*/
        public virtual Contact Contact { get; set; }

        public virtual ICollection<Location> LocationsList { get; set; }

        public int UserID { get; set; }

    }
}
