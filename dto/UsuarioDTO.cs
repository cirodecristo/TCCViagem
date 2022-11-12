namespace dto;

public class UsuarioDTO   //criei uma biblioteca que posso usar tanto no back quanto no front
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? Password { get; set; }
    public string? UserId { get; set; }
}
