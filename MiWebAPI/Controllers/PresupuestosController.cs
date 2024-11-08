using Microsoft.Data.Sqlite;

namespace MiWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PresupuestosController : ControllerBase
{
    private readonly ILogger<PresupuestosController> _logger;

    public PresupuestosController(ILogger<PresupuestosController> logger)
    {
        _logger = logger;

    }

    

}
