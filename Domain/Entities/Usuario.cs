
namespace Domain.Entities;

public class Usuario : BaseEntity
{
    
    public string Username { get; set; }
    public string DNI { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public ICollection<Rol> Roles { get; set; } = new HashSet<Rol>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
    public ICollection<UsuarioRol> UsuarioRoles { get; set; }
}
