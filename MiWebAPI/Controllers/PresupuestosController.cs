using Microsoft.AspNetCore.Mvc;

namespace MiWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PresupuestosController : ControllerBase
{
    private readonly ILogger<PresupuestosController> _logger;
    private PresupuestosRepository presRepo;

    public PresupuestosController(ILogger<PresupuestosController> logger)
    {
        _logger = logger;
        presRepo = new PresupuestosRepository();
    }

    [HttpPost("/api/Presupuesto")]
    public IActionResult CrearProductos(Presupuestos presupuesto)
    {
        presRepo.CrearNuevoPresupuesto(presupuesto);
        return Created();
    }

    [HttpPost("/api/Presupuesto/{id}/ProductoDetalle")]
    public IActionResult DetallesPresupuesto(int idPresupueso)
    {
        
        return Ok(presRepo.DetallesPresupuestoId(idPresupueso));
    }

    [HttpGet("/api/presupuesto")]
    public IActionResult ListarPresupuestosExistentes(){
        return Ok(presRepo.ListarPresupuestos());
    }

   

}