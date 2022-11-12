using System;
using System.Collections.Generic;

namespace back.Model
{
    public partial class Formulario
    {
        public int Id { get; set; }
        public string VisitedCity { get; set; } = null!;
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}
