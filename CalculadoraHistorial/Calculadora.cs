namespace EspacioCalculadora;

using EspacioOperaciones;
public class Calculadora
{
    private double resultado;
    private List<Operacion> historial = new();

    //Propiedad de resultado
    public double Resultado => resultado;
    
    public List<Operacion> Historial => historial;

    public void Sumar(double termino)
    {
        historial.Add(new Operacion(resultado, termino, TipoOperacion.Suma));
        resultado += termino;
    }
    public void Restar(double termino)
    {
        historial.Add(new Operacion(resultado, termino, TipoOperacion.Resta));
        resultado -= termino;
    }
    public void Multiplicar(double termino)
    {
        historial.Add(new Operacion(resultado, termino, TipoOperacion.Multiplicacion));
        resultado *= termino;
    }
    public void Dividir(double termino)
    
    {
        historial.Add(new Operacion(resultado, termino, TipoOperacion.Division));
        if (termino != 0)
        {
            resultado /= termino;
        }
    }
    public void Limpiar()
    {
        historial.Add(new Operacion(resultado, 0, TipoOperacion.Limpiar));
        resultado = 0;
    }
    public void MostrarHistorial()
    {
        if (historial.Count == 0)
        {
            Console.WriteLine("No hay operaciones registradas.");
        }
        else
        {
            Console.WriteLine("Historial de operaciones:");
            foreach (var op in historial)
            {
                if (op.Tipo==TipoOperacion.Limpiar)
                {
                    Console.WriteLine("El Historial fue Limpiado.");
                }else
                {
                    Console.WriteLine(op.Resultado + " = " + op.NuevoValor + " " + op.Tipo + " " + op.ResultadoAnterior);
                }
            }
        }
    }
}