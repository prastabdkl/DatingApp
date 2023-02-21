namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        public string UserName { get; set; } //declaring nullable using string? , string? will make the UserName optional, instead disable nullable from api.csproj file
    }
}