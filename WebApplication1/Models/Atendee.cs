using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Atendee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Attending { get; set; }
        public string Date { get; set; }
        public string Guest { get; set; }

        public Atendee() { }

        public Atendee(string firstName, string lastName, string email, string attending, string date, string guest)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Attending = attending;
            Date = date;
            Guest = guest;
        }
    }
}