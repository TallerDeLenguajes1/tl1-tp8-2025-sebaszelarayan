namespace EspacioTareas;

public class Tarea
{
    public int TareaID { get; set; }
    public string Descripcion { get; set; }
    public int Duracion { get; set; }

    public Tarea(int id, string descripcion, int duracion)
    {
        TareaID = id;
        Descripcion = descripcion;
        Duracion = duracion < 10 ? 10 : duracion > 100 ? 100 : duracion;
    }

    public void Mostrar()
    {
        Console.WriteLine($"ID: {TareaID} | Descripción: {Descripcion} | Duración: {Duracion} minutos");
    }
}
