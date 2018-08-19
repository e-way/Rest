using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Model
{
    public class Emails
    {
        public string email { get; set; }
        public bool primary { get; set; }
        public bool verified { get; set; }
        public string visibility { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            var receivedEmails = obj as Emails;
            return email == receivedEmails.email &&
                   primary == receivedEmails.primary &&
                   verified == receivedEmails.verified &&
                   visibility == receivedEmails.visibility;
        }
    }
}
