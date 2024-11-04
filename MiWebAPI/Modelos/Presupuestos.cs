public class Presupuestos{
    private int idPresupuesto;
    private string nombredestinatario;
    private List<PresupuestoDetalle> detalle;

    public int IdPresupuesto { get => idPresupuesto; set => idPresupuesto = value; }
    public string Nombredestinatario { get => nombredestinatario; set => nombredestinatario = value; }
    public List<PresupuestoDetalle> Detalle { get => detalle; set => detalle = value; }

    public void MontoPresupuesto(){

    }

    public void MontoPresupuestoConIva(){

    }
    public void CantidadProductos(){
        
    }

}