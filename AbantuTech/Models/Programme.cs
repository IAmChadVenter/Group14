﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Abantu_System.Models
{
    public class Programme
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Programme_ID { get; set; }

        [Required(ErrorMessage = "*")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "*")]
        [MaxLength(200)]
        public string Description { get; set; }

        ////Navigational properties:
        //public int? Budget_ID { get; set; }
        //public virtual Budget Budget { get; set; }

        public ICollection<Event> Events { get; set; }

        public int? Committee_ID { get; set; }
        public Committee Committee { get; set; }

        ////for many-to-to many references
        //public virtual ICollection<ProgrammeMember> ProgrammeMembers { get; set; }
    }
}