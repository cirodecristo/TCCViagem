using dto;
using System.Threading.Tasks;
using System.Net.Http;


namespace front.Services;

public class UserService
{
    HttpClient client;

    public UserService(string server)
    {
        client = new HttpClient();
        client.BaseAddress = new Uri(server);  //alguem tem que passar o nome do servidor para informar aqui
    }
    public async Task Register(
        string name,
        string userId,
        DateTime birth,
        string password)
    {
        UsuarioDTO user = new UsuarioDTO();
        user.Name = name;
        user.UserId = userId;
        user.Password = password;
        user.BirthDate = birth;

        var result = await client.PostAsJsonAsync("user/register", user);
    }
}