using System;
using System.Collections.Generic;

namespace back.Model
{
    public partial class Usuarios
    {
        public Usuarios()
       
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string Userpass { get; set; } = null!;

       
    }
}
