﻿namespace FinalProject.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class LoginAttempt
    {

        public LoginAttempt(UserModel user)
        {
            this.User = user;
        }

        public UserModel User { get; set; }
    }
}