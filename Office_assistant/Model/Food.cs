﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Office_assistant.Model
{
    public class Food
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IEnumerable<subFood> subFoods { get; set; }
    }

    
}
