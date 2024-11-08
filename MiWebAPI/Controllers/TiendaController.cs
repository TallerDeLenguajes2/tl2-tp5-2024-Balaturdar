using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

namespace MiWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PresupuestosController : ControllerBase
{
    private readonly ILogger<PresupuestosController> _logger;
    string CadenaDeConexion;

    public PresupuestosController(ILogger<PresupuestosController> logger)
    {
        string CadenaDeConexion = "Data Source=db/Tienda.db;";
        _logger = logger;
    }

    [HttpGet("GetProductos")]
    public ActionResult GetProductos (){
        
        return Ok();
    }

}
