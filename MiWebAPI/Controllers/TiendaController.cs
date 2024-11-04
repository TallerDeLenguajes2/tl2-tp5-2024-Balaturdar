using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

namespace MiWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TiendaController : ControllerBase
{
    private readonly ILogger<TiendaController> _logger;
    string CadenaDeConexion;

    public TiendaController(ILogger<TiendaController> logger)
    {
        string CadenaDeConexion = "Data Source=db/Tienda.db;";
        _logger = logger;
    }

    [HttpGet("GetProductos")]
    public ActionResult GetProductos (){
        
        return Ok();
    }

}
