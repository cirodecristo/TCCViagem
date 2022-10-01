using Microsoft.AspNetCore.Mvc;
using dto;

namespace back.Controllers;

using Model;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{   
    [HttpPost("login")]   //tags com [] controlam sem que precise colocar classes
    public IActionResult Login()
    {
        //return.Ok(); return NotFound , return.ok("OI");
        throw new NotImplementedException();
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] UsuarioDTO user)
    {
        //throw new NotImplementedException();
        using TDSABADO2Context context = new TDSABADO2Context();
        Usuario usuario = new Usuario();
        usuario.Name = user.Name;
        usuario.BirthDate = user.BirthDate;
        usuario.UserId = user.UserId;
        usuario.Userpass = user.Password;

        context.Add(usuario);
        context.SaveChanges();
        

        return Ok();
    }


    [HttpPost("update")]
    public IActionResult UpdateName()
    {
        throw new NotImplementedException();
    }

}
