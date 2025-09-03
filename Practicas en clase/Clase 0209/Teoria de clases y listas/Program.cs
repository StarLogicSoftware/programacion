
List<SegmentoHierro> hierritos = new List<SegmentoHierro>();

SegmentoHierro s1 = new SegmentoHierro();
s1.Largo = 12;
s1.Diametro = 6;

SegmentoHierro s2 = new SegmentoHierro();
s2.Largo = 16;
s2.Diametro = 5;

SegmentoHierro s3 = new SegmentoHierro();
s3.Largo = 12;
s3.Diametro = 8;

hierritos.Add(s1);
hierritos.Add(s2);
hierritos.Add(s3);

// Devuelve el primer elemento que cumple con la condicion
//SegmentoHierro segmentoBuscado = hierritos.Find(s => s.Largo == 12);

// Devuelve el ultimo elemento que cumple con la condicion
//SegmentoHierro segmentoBuscado = hierritos.FindLast(s => s.Largo == 12);

//if (segmentoBuscado == null)
//{
//    Console.WriteLine("No se encontro el segmento buscado");
//}
//else
//{
//    Console.WriteLine("Diametro del segmento buscado: " + segmentoBuscado.Diametro);
//}

// Devuelve todos los elementos que cumplen con la condicion
List<SegmentoHierro> segmentosBuscados = hierritos.FindAll(s => s.Largo == 12);

foreach (var pedacito in segmentosBuscados)
{
    Console.WriteLine("Diametro del segmento buscado: " + pedacito.Diametro);
}

//if (segmentosBuscados.Count == 0)
//{
//    Console.WriteLine("No se encontro el segmento buscado");
//}
//else
//{
//    foreach (var item in segmentosBuscados)
//      {
//          Console.WriteLine("Diametro del segmento buscado: " + item.Diametro);
//      }
//}

//hierritos.Remove(s1); // Elimina la primera ocurrencia de s1 en la lista
//hierritos.Clear(); // Elimina todos los elementos de la lista

/*
--- Metodos a usar con listas ---
lista.Add(elemento);       -> Agrega un elemento al final de la lista
lista.Count;         -> Devuelve la cantidad de elementos en la lista
lista.Remove(elemento);    -> Elimina la primera ocurrencia del elemento en la lista
lista.Clear();        -> Elimina todos los elementos de la lista
lista.find(condicion);   -> Devuelve el primer elemento que cumple con la condicion
 */

//Console.WriteLine("Cantidad de elementos en la lista: " + hierritos.Count);

class SegmentoHierro
{
    public int Largo;
    public int Diametro;
}