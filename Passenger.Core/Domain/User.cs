using System;

namespace Passenger.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }
        
        public string Email { get; protected set; }
        
        public string Password { get; protected set; }
        
        public string Salt { get; protected set; }
        
        public string Username { get; protected set; }
        
        public string FullName { get; protected set; }
        
        public DateTime CreatedAt { get; protected set; }

        protected User()
        {
        }

        public User(string email, string username, 
            string password, string salt)
        {
            this.Id = Guid.NewGuid();
            
            this.Email = email.ToLowerInvariant();
            this.Username = username;
            this.Password = password;
            this.Salt = salt;
            this.CreatedAt = DateTime.UtcNow;
        }
    }
}