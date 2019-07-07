using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo
{
    public class DemoUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUsername { get; set; }
        public string PasswordHash { get; set; }
    }
}
