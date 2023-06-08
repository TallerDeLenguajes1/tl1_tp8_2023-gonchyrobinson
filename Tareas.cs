using System;
namespace Tareas
{
    class Tareas
    {
        Random rand = new Random();
        private int tareaId;
        private string? descripcion;
        private int duracion;
        private Estado estadoTarea;

        public int TareaId { get => TareaId; set => TareaId = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public Estado EstadoTarea { get => estadoTarea; set => estadoTarea = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }

        public Tareas(int id, string? Descripcion, Estado estado){
            tareaId=id;
            descripcion=Descripcion;
            duracion=rand.Next(10,100);
            estadoTarea=estado;
        }
        public string Mostrar(){
            return("\nID: "+ tareaId+"\nDescripcion: "+ descripcion+"\nDuracion: "+duracion+"\nEstado: "+estadoTarea);
        }
        public int DuracionTarea(){
            return(duracion);
        }
        public void CambiaEstadoARealizado(){
            estadoTarea=Estado.realizadas;
        }

    }
    public enum Estado
    {
        pendientes = 0,
        realizadas = 1,

    }
}