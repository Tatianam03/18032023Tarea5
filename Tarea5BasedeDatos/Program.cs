using System;
using Tarea5BasedeDatos;
using Tarea5BasedeDatos.Models;

Producto producto = new Producto();
using (AlmacenContext db = new AlmacenContext())
{
    Console.WriteLine("Ingrese el nombre del producto");
    producto.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la descripcion");
    producto.Descripcion = Console.ReadLine();
    Console.WriteLine("Ingrese el precio");
    producto.Precio = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el Stock");
    producto.Stock = int.Parse(Console.ReadLine());

    db.Add(producto);
    db.SaveChanges();
    Console.WriteLine("Su producto fue ingresado con exito !\n");

    var lista = db.Productos.ToList();
    foreach (var mostrar in lista)
    {
        Console.WriteLine("\nNombre:  " + mostrar.Nombre);
        Console.WriteLine("Descripcion: " + mostrar.Descripcion);
        Console.WriteLine("Precio  " + mostrar.Precio);
        Console.WriteLine("Stock " + mostrar.Stock);
    }

}