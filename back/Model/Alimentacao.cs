using System;
using System.Collections.Generic;

namespace back.Model
{
    public partial class Alimentacao
    {
        public int Id { get; set; }
        public string PlaceName { get; set; } = null!;
        public string AmountSpent { get; set; } = null!;
        public string TypeFood { get; set; } = null!;
        public string Comments { get; set; } = null!;
    }
}
