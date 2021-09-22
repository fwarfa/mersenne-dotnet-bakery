using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_bakery
{

    public class Bread {

        public int id {get; set;}

        public string name  {get; set;}

        public string description {get; set;}

        [ForeignKey("Bakers")]
        public int bakedById {get; set;}

        public Baker bakedBy { get; set; }

    }

}