using Tareas;
using System.Collections.Generic;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        var pendientes = new List<Tareas.Tareas>();
        var realizadas = new List<Tareas.Tareas>();
        var random = new Random();
        int cant = random.Next(1, 3);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("\n-----------------------------------------------\n\tDescripcion:  ");
            string? descripcion = Console.ReadLine();
            pendientes.Add(new Tareas.Tareas(i, descripcion, 0));
        }

        MueveTareas(pendientes, realizadas);
        
        BuscaTareaPorDescripcion(pendientes);

        int horasTotales = SumaTareas(realizadas);
            
        StreamWriter archivo = new StreamWriter(@"C:\Users\USUARIO\tl1_tp8_2023-gonchyrobinson\horas.txt");
        archivo.WriteLine("Horas Trabajadas: "+ horasTotales);
        archivo.Close();


    }
    static void MueveTareas(List<Tareas.Tareas> pendientes, List<Tareas.Tareas> realizadas)
        {
            Console.WriteLine("\n=============================MENU=========================================\n");
            int realizada;
            string? realizadaSTR;
            int cantElementos=pendientes.Count;
            int indice=0;
            for (int i = 0; i < cantElementos; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine(pendientes[indice].Mostrar());
                Console.WriteLine("\nRealizada = 1, pendiente = 0:  ");
                realizadaSTR = Console.ReadLine();
                if (int.TryParse(realizadaSTR, out realizada))
                {
                    if (realizada == 1)
                    {
                        pendientes[indice].CambiaEstadoARealizado();
                        realizadas.Add(pendientes[indice]);
                        pendientes.RemoveAt(indice);
                        indice--;
                    }
                }
                indice++;
            }
        }
    static void BuscaTareaPorDescripcion(List<Tareas.Tareas> pendientes)
        {
            Console.WriteLine("\n-----------------------------------------BUSCAR POR DESCRIPCION TAREAS PENDIENTES------------------------------------\n");
            Console.WriteLine("\n Descripcion:  ");
            string? Descripcion = Console.ReadLine();
            Tareas.Tareas buscada = pendientes.Find(pendientes => pendientes.Descripcion == Descripcion);
            if (buscada != null)
            {
                Console.WriteLine("\nTAREA BUSCADA:  ");
                Console.WriteLine(buscada.Mostrar());
            }
            else
            {
                Console.WriteLine("\nNo se encontro la tarea con la descripcion mencionada");
            }
        }
    static int SumaTareas(List<Tareas.Tareas> realizadas)
        {
            int HorasTrabajadas = (realizadas.Sum(pendientes => pendientes.DuracionTarea()));
            Console.WriteLine("\n================================================\nHORAS TRABAJADAS:  " + HorasTrabajadas);
            return(HorasTrabajadas);
        }
}