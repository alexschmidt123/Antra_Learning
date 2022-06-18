﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Trailer
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        [MaxLength(2084)]
        public string TrailerUrl { get; set; }
        [MaxLength(2084)]
        public string Name { get; set; }
        public Movie Movie { get; set; }    
    }
}
