namespace LoginSystem.Models
{
    // Everything in this class is a member
    public class User
    {
        public string Name { get; set; }
        private string Password { get; set; }
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public bool ValidatePassword(string input) {
            return input == Password;
        }
    }
}