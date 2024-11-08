using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

namespace MiWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductosController : ControllerBase
{
    private readonly ILogger<ProductosController> _logger;
    private ProductosRepository prodRepo;

    public ProductosController(ILogger<ProductosController> logger)
    {
        _logger = logger;
        prodRepo = new ProductosRepository();
    }

    [HttpPost("api/Producto")]
    public IActionResult CrearProductos(Productos producto)
    {
        prodRepo.CrearProducto(producto);
        return Created();
    }

    [HttpGet("/api/Producto")]
    public IActionResult ListarProductosExistentes(){
        return Ok(prodRepo.ListarProductos());
    }

    [HttpPut("/api/Producto/{id}")]
    public IActionResult ModificarNombreProducto(int id, [FromBody] Productos producto){
        prodRepo.ModProducto(id,producto);
        return Ok();
    }


}
