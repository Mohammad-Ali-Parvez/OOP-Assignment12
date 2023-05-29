using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment12

    {

        public class contact
        {
            public contact(string email, string mobile)
            {
                Email = email;
                Mobile = mobile;
            }

            public string Email { get; set; }
            public string Mobile { get; set; }

            public override string ToString()
            {
                return "Email:" + Email + "phone" + Mobile;
            }

        }
        public class members
        {
            public string Name { get; set; }
            public DateTime DateOfBirth { get; set; }
            public List<contact> ContactInformation { get; set; }
        }

    }