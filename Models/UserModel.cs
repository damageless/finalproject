namespace FinalProject.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class UserModel
    {
        public UserModel()
        {

        }

        public UserModel(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string username { get; set; }

        public string password { get; set; }
    }
}