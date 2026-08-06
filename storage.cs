using System;
using System.Collections.Generic;
namespace MessengerDraft_1
{
    public class User
    {
        public string userId { get; set; }
        public string name { get; set; }
        public string Password { get; set; }
    }

    public static class GlobalData
    {
        public static List<User> Users = new List<User>();
    }
}

