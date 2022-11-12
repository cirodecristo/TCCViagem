using System;
using System.Collections.Generic;

namespace back.Model
{
    public partial class Hospedagem
    {
        public int Id { get; set; }
        public string TypeHosting { get; set; } = null!;
        public string AmountSpent { get; set; } = null!;
        public string PlaceName { get; set; } = null!;
        public string? Link { get; set; }
        public string Comments { get; set; } = null!;
    }
}
