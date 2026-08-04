using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerDraft_1
{
    internal class ContactRepo
    {

        public static List<Contact> contactUsers = new List<Contact>()
        {
            new Contact() { id="24-12345-3",name="DC",status="Online"},
            new Contact() { id="24-12345-4",name="AC"},
        };
    }
}
