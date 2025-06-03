// See https://aka.ms/new-console-template for more information
using EspacioTareas;
using System.Collections.Generic;

//Punto 1 Creacion de N tareas
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();
Random rnd = new Random();

int operador = 0;

Console.Write("Ingrese la cantidad de tareas a generar: ");
string? n = Console.ReadLine();
int N = 0;
bool resultado = int.TryParse(n, out N);
if (resultado)
{
    for (int i = 1; i <= N; i++)
    {
        string descripcion = $"Tarea #{i}";
        int duracion = rnd.Next(10, 101); // Duración entre 10 y 100
        tareasPendientes.Add(new Tarea(i, descripcion, duracion));
    }
    Console.WriteLine("\nTareas generadas:");
    foreach (var tarea in tareasPendientes)
    {
        tarea.Mostrar();
    }
    do
    {
        Console.WriteLine("\nOperaciones\n 0 = Salir del Programa\n 1 = Marcar Tareas Realizadas\n 2 = Mostrar Listas \n 3 = Consultar Tarea\n");
        string? o = Console.ReadLine();
        bool resultado0 = int.TryParse(o, out operador);
        if (resultado0)
        {
            switch (operador)
            {
                case 1: MoverTarea(tareasPendientes,tareasRealizadas);
                    break;
                case 3: BuscarTarea(tareasPendientes);
                    break;
                case 2: MostrarTareas(tareasPendientes,tareasRealizadas);
                    break;
                case 0: Console.WriteLine("Saliendo del programa ....\n");
                    break;
                default: Console.WriteLine("Opción inválida.");
                    break;
            }
        }else
        {
            Console.WriteLine($"El valor {o} no se puede transformar a entero.");
        }
        
    } while (operador != 0);
}
else
{
    Console.WriteLine($"El valor {n} no se puede transformar a entero.");
}
void MoverTarea(List <Tarea> tareasPendientes,List <Tarea> tareasRealizadas)
{
    Console.Write("Ingrese el ID de la tarea a marcar como realizada: ");
    string? id = Console.ReadLine();
    int ID = 0;
    bool resultado1 = int.TryParse(id, out ID);
    if (resultado1)
    {
        Tarea? tareaSelecionada = null;
        foreach (Tarea tarea in tareasPendientes)
        {
            if (tarea.TareaID == ID)
            {
                tareaSelecionada = tarea;
            }

        }
        if (tareaSelecionada != null)
        {
            tareasRealizadas.Add(tareaSelecionada);
            tareasPendientes.Remove(tareaSelecionada);
        }
    }
    else
    {
        Console.WriteLine("ID inválido.");
    }

}
void BuscarTarea(List <Tarea> tareasPendientes)
{
    Console.Write("Ingrese texto a buscar en descripción: ");
    string? texto = Console.ReadLine();
    bool resultados =false;
    foreach (Tarea tarea in tareasPendientes)
    {
        if (texto == tarea.Descripcion)
        {
            resultados = true;
            tarea.Mostrar();
        }
    }
    if (!resultados)
    {
        Console.WriteLine("No se encontraron tareas con esa descripción.");
    }
}

void MostrarTareas(List <Tarea> tareasPendientes,List <Tarea> tareasRealizadas)
    {
        Console.WriteLine("\nTAREAS PENDIENTES:");
        foreach (Tarea tarea in tareasPendientes)
            tarea.Mostrar();

        Console.WriteLine("\nTAREAS REALIZADAS:");
        foreach (Tarea tarea in tareasRealizadas)
            tarea.Mostrar();
    }


