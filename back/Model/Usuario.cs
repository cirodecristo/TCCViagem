using System;
using System.Collections.Generic;

namespace back.Model
{
    public partial class Usuario
    {
        public Usuario()
        {
            Tokens = new HashSet<Token>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string Userpass { get; set; } = null!;

        public virtual ICollection<Token> Tokens { get; set; }
    }
}
