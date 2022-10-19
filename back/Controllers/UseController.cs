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
        using WebSiteViagemContext context = new WebSiteViagemContext();
        Usuario usuario = new Usuario();
        usuario.Name = user.Name;
        usuario.Email = user.Email;
        usuario.City = user.City;
        usuario.Country = user.Country;
        usuario.Phone = user.Phone;
        usuario.UserId = user.UserId;
        usuario.Userpass = user.Password;

        List<string> errors = new List<string>();
        if(usuario.Name.Length < 5)
        {
            //return BadRequest();
            errors.Add("O nome do usuário precisa conter ao menos 5 letras.");
        }

        if (context.Usuarios
            .Any(u => u.UserId == user.UserId))
            {
                errors.Add("Seu nome de usu[ario já está em uso!");
            }

        if (errors.Count > 0)
        {
            return this.BadRequest(errors);
        }                  

        // var query2 = 
        //     from u in context.Usuarios
        //     where u.Name == user.UserId
        //     select u;

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
