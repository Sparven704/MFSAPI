﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MFSAPI.Models
{
    public partial class PersonGenre
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Person Person { get; set; }
    }
}