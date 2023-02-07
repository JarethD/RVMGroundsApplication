using System;

namespace RVMGroundsApplication.Models
{
    class Admin :  User
    {
        bool admin;
        bool isAdmin { get { return admin; } set { admin = true; } }


    }

}