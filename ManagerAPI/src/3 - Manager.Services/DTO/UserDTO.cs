namespace Manager.Services.DTO
{
    public class UserDTO
    {
        public UserDTO()
        { }

        public UserDTO(long id,
                       string name,
                       string email,
                       string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}