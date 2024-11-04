using System.ComponentModel;
using Microsoft.Data.Sqlite;

public class ProductosRepository{
    string CadenaDeConexion;

    ProductosRepository()
    {
        CadenaDeConexion = "Data Source=db/Tienda.db";
    }

    /*

        Crear un nuevo Producto. (recibe un objeto Producto)
        Modificar un Producto existente. (recibe un Id y un objeto Producto)
        Listar todos los Productos registrados. (devuelve un List de Producto)
        Obtener detalles de un Productos por su ID. (recibe un Id y devuelve un
        Producto)
        Eliminar un Producto por ID

    */

    public void CrearProducto(Productos producto){
        using(SqliteConnection connection = new SqliteConnection(CadenaDeConexion)){
            string queryString = @"INSERT INTO Productos (Descripcion, Precio) 
                                VALUES ('Mouse Inalámbrico Logitech', 5000);
                                ";
            connection.Open();
            var command = new SqliteCommand( queryString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public void ModProducto(int id, Productos producto){

    }

    public List<Productos> ListarProductos(){

        var productos = new List<Productos>();
        using(SqliteConnection connection = new SqliteConnection(CadenaDeConexion)){
            string queryString = @"SELECT idProducto, Descripcion, Precio From Productos";
            var command = new SqliteCommand( queryString, connection);
            connection.Open();
            using(SqliteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var producto = new Productos();
                    producto.IdProductos = Convert.ToInt32(reader["idProductos"]);
                    producto.Descripcion = reader["Descripcion"].ToString();
                    producto.Precio = Convert.ToInt32(reader["Precio"]);
                    productos.Add(producto);
                }
            }
            command.ExecuteReader();
            connection.Close();
        }
        return productos;
    }

//Obtener detalles de un Productos por su ID.
    public Productos DetalleProductoId(int id){
        var producto = new Productos();
        using(SqliteConnection connection = new SqliteConnection(CadenaDeConexion)){
            string queryString = @"SELECT idProducto, Descripcion, Precio From Productos WHERE idProductos = @id";
            var command = new SqliteCommand( queryString, connection);
            connection.Open();
            command.Parameters.Add("@id", SqliteType.Integer);
            command.Parameters["@ID"].Value = id;
            using(SqliteDataReader reader = command.ExecuteReader())
            {
                reader.Read();
                producto.IdProductos = Convert.ToInt32(reader["idProductos"]);
                producto.Descripcion = reader["Descripcion"].ToString();
                producto.Precio = Convert.ToInt32(reader["Precio"]);
            }
            command.ExecuteReader();
            connection.Close();
        }
        return new Productos();
    }

    public void EliminarProductoId(int id){

    }





}