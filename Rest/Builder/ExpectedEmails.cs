using Rest.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Builder
{
    public class ExpectedEmails
    {
        public static Emails GetExpectedUser()
        {
            return new Emails
            {
                email = "y9415019@hotmail.com",
                primary = true,
                verified = true,
                visibility = "public"
            };
        }
    }
}
