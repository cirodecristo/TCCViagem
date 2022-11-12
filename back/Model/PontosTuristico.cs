using System;
using System.Collections.Generic;

namespace back.Model
{
    public partial class PontosTuristico
    {
        public int Id { get; set; }
        public string TypeAttraction { get; set; } = null!;
        public string AmountSpent { get; set; } = null!;
        public string TypeTransport { get; set; } = null!;
        public string Comments { get; set; } = null!;
    }
}
