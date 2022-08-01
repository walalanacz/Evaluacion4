using Evaluacion4.Models;

Console.WriteLine("Evaluación 4");

using (EFContext bd = new EFContext())
{

    //SELECT * FROM Automotora;
    // var todosAutomotoras = bd.Automotoras.ToList();
    // foreach (var automotora in todosAutomotoras)
    //{
    //     Console.WriteLine(automotora.Nombre);
    // } 

    // SELECT * FROM Automotora WHERE Nombre = 'Dodge';
    /* var automotorasNombre = bd.Automotoras
        .Where(x => x.Nombre == "Dodge")
        .ToList(); */


    // SELECT COUNT(Titulo) FROM Album;
    //int total = bd.Automotoras.Count();

    /* 5) Obtener el ID mayor de canciones */
    // SELECT MAX(Id) FROM Cancion;
     //int max = bd.Autos.Max(x => x.Id);

    /* 6) Obtener el ID menor de canciones */
    // SELECT MIN(Id) FROM Cancion;
    //int min = bd.Autos.Min(x => x.Id);

    /* 7) Obtener el promedio de duración de canciones */
    // SELECT AVG(Duracion) FROM Cancion
    //double promedioDuracion = bd.Canciones.Average(x => x.Duracion);

    /* 8) Obtener los álbumes cuyos IDs estén entre 3 y 4,
    *     ordenados por Id de forma descendente
    */
    // SELECT * FROM Album WHERE Id >= 3 AND Id <= 4
    // ORDER BY Id DESC;
    /* var albumesOrdenados = bd.Albumes
        .Where(x => x.Id >= 3 && x.Id <= 4)
        .OrderByDescending(x => x.Id)
        .ToList(); */

    /* 9) Obtener un sólo álbum a través de su ID (3) */
    // SELECT * FROM Album WHERE Id = 3;
    // var album = bd.Albumes.Where(x => x.Id == 3).First();
    //var album = bd.Albumes.FirstOrDefault(x => x.Id == 3);

    /* 10) Actualizar el título del álbum "Perdónala" a "Perdónala (Remix)"
           a través de la búsqueda de su id */
    // UPDATE Album SET Titulo = 'Perdónala (Remix)' WHERE Id = 3;
    /* var albumEditar = bd.Albumes.FirstOrDefault(x => x.Id == 3);
    albumEditar.Titulo = "Perdónala (Remix)";
    bd.Albumes.Update(albumEditar);
    bd.SaveChanges(); */

    /* 11) Insertar un nuevo álbum, sin un ID existente aun, que posea
           las siguientes características:
           Nombre: "Al Pachak", Lanzamiento: El 20 de julio del 2022,
           No se poseen datos sobre su topSeller. 
           Productora: "Mastropiero que nunca"                    
    */
    // INSERT INTO Album(Titulo, Lanzamiento, TopSeller, Productora)
    // VALUES("Al Pachak", "2022-07-20", Null, "Mastropiero que nunca");
    /* Album nuevoAlbum = new Album();
    nuevoAlbum.Id = 0; // Dejar en cero si no existe ID como en una inserción
    nuevoAlbum.Titulo = "Al Pachak";
    nuevoAlbum.Lanzamiento = Convert.ToDateTime("2022-07-20");
    nuevoAlbum.TopSeller = null;
    nuevoAlbum.Productora = "Mastropiero que nunca"; */

    /*Album nuevoAlbum = new Album()
    {
        Id = 0,
        Titulo = "Al Pachak",
        Lanzamiento = Convert.ToDateTime("2022-07-20"),
        TopSeller = null,
        Productora = "Mastropiero que nunca"
    };
    bd.Albumes.Add(nuevoAlbum);
    bd.SaveChanges(); */

    /* 12) Eliminar la canción "Configurable 4th generation time-frame"
           a través de la búsqueda de su ID (29)
    */
    var cancionEliminar = bd.Autos.FirstOrDefault(x => x.Id == 29);
    bd.Autos.Remove(cancionEliminar);
    bd.SaveChanges();

}