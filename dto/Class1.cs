namespace dto;

public class UsuarioDTO   //criei uma biblioteca que posso usar tanto no back quanto no front
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string Password { get; set; }
    public string UserId { get; set; }
}
