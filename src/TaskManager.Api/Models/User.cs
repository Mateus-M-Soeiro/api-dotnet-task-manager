using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TaskManager.Api.DTOs
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email {get; set;}

        public string PasswordHarsh { get; set; }

    }
}