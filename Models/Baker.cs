using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_bakery
{
    // This model represents (or is "mapped" to)
    // our "Baker" database table
    public class Baker {

        public int id {get; set;}

        [Required]
        public string name {get; set;}

    }
}
