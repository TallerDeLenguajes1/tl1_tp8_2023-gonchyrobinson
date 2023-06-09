using Tareas;
using System.Collections.Generic;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] archivosConExt;
        string[] archivos = Directory.GetFiles(@"C:\Users\USUARIO\Desktop\TERCERANIOFACULTAD\Arquitectura_de_computadoras");
        int i=0;
        StreamWriter archivo = new StreamWriter(Directory.GetCurrentDirectory()+@"\index.csv");
        string[] partesDeRuta;
       foreach (var item in archivos)
       {
            archivosConExt= item.Split('.');
            Console.WriteLine(archivosConExt[0]+"  -   "+archivosConExt[1]);
            partesDeRuta=archivosConExt[0].Split(@"\");
            archivo.WriteLine(i+","+partesDeRuta[partesDeRuta.Count()-1]+","+archivosConExt[1]);            
            i++;
       }
       archivo.Close();

    }
}