//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        private string userEmail;

        public user()
        {
            this.usertasks = new HashSet<usertask>();
        }

        public user(string firstName, string lastName, string userEmail, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            this.userEmail = userEmail;
            Password = password;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<usertask> usertasks { get; set; }
    }
}
