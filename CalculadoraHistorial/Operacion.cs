namespace EspacioOperaciones;
public enum TipoOperacion{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar // Representa la acción de borrar el resultado actual o el historial
}
public class Operacion
{
    private double resultadoAnterior; // Almacena el resultado previo al cálculo actual
    private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
    private TipoOperacion operacion;// El tipo de operación realizada

    public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
    {
        this.resultadoAnterior = resultadoAnterior;
        this.nuevoValor = nuevoValor;
        this.operacion = operacion;
    }

    public double Resultado
    {
        /* Lógica para calcular o devolver el resultado */
        get
        {
            return operacion switch
            {
                TipoOperacion.Suma => resultadoAnterior + nuevoValor,
                TipoOperacion.Resta => resultadoAnterior - nuevoValor,
                TipoOperacion.Multiplicacion => resultadoAnterior * nuevoValor,
                TipoOperacion.Division => nuevoValor != 0 ? resultadoAnterior / nuevoValor : double.NaN,
                TipoOperacion.Limpiar => 0,
                _ => resultadoAnterior
            };
        }
    }
    // Propiedad pública para acceder al nuevo valor utilizado en la operación
    public double NuevoValor
    {
        get => nuevoValor; set => nuevoValor = value;
    }
    public double ResultadoAnterior
    {
        get => resultadoAnterior; set => resultadoAnterior = value;
    }
    public TipoOperacion Tipo
    {
        get => operacion; set => operacion = value;
    }
    
}


