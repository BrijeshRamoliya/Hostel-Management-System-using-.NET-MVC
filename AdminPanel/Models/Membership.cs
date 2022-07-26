using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPanel.Models
{
    public class Membership 
    {
        public int UserId { get; set; }
        public int Username { get; set; }
        public int EmailId { get; set; }
        public int Password { get; set; }
        public int ConfirmPassword { get; set; }
    }
}