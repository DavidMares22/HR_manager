using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_manager.Shared.DTOs
{
    public class ErrorResponse
    {
        public string title { get; set; }
        public string[] DuplicateEmail { get; set; }
        public string[] PasswordRequiresNonAlphanumeric { get; set; }

        public string[] PasswordRequiresLower { get; set; }
        public string[] PasswordRequiresUpper { get; set; }

        public string[] InvalidEmail { get; set; }
        


        public ErrorArr errors { get; set; }



        public override string ToString()
        {
            string res = "";

            if (title != null)
            {
                res += " " + title;
            }
            if (errors != null && errors.Email != null)
            {
                res += " " + errors.Email[0];
            }
            if (errors != null && errors.Password != null)
            {
                res += " " + errors.Password[0];
            }
            if (DuplicateEmail != null)
            {
                res += " " + DuplicateEmail[0];
            }

            if (PasswordRequiresNonAlphanumeric != null)
            {
                res += " " + PasswordRequiresNonAlphanumeric[0];
            }

            if (PasswordRequiresLower != null)
            {
                res += " " + PasswordRequiresLower[0];
            }

            if (PasswordRequiresUpper != null)
            {
                res += " " + PasswordRequiresUpper[0];
            }

            if (InvalidEmail != null)
            {
                res += " " + InvalidEmail[0];
            }
            

            return  res;
        }
    }

    public class ErrorArr
    {
        public string[] Email { get; set; }
        public string[] Password { get; set; }

       

    }
}
