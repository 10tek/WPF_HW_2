using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public string ImagePath { get; set; }
        public string HobbyList { get; set; }
        public string Login { get; set; }
    }
}
