using DemoBD;

using (var db = new AppDbContext())
{
    Libro l1 = new Libro()
    {
        Titulo = "Lab de futuros",
        Autor = "Valentina Paduan",
    };

    db.Libros.Add(l1);

    db.SaveChanges();
}

using (var db = new AppDbContext())
{
    var libros = db.Libros.ToList();
    foreach (var libro in libros)
    {
        Console.WriteLine($"Id: {libro.Id}, Título: {libro.Titulo}, Autor: {libro.Autor}");
    }
}