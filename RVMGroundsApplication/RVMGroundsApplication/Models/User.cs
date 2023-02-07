using System;

namespace RVMGroundsApplication.Models
{
	class User
    {
        string username { get; set; }
        string password { get; set; }
        string hash { get; set; }
        string name { get; set; }
        long phoneNum { get; set; }
        string row { get; set; }
        string jobTitle { get; set; }

        bool admin;
        bool isAdmin { get { return admin; } set { admin = false; } }
    }
}