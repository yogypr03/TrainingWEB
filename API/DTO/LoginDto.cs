using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace API.DTO
{
    public class LoginDto
    {
        public string Username {get; set;}
        public string Password {get;set;}
    }
}