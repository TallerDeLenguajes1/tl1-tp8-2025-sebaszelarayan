using EspacioCalculadora;

Calculadora Calc = new Calculadora();
int op = 0;
do
{
    Console.WriteLine("Ingrese un Numero Segun la operacion deseada:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Limpiar");
    Console.WriteLine("6. Ver historial");
    Console.WriteLine("0. Salir");
    string? sop = Console.ReadLine();
    bool resultop = int.TryParse(sop, out op); //op=numerico
    if (resultop)
    {
        if (op == 0)
        {
            Console.WriteLine("Saliendo...");
            Calc.Limpiar();
        }
        else
        {
            if (op > 0 && op < 5)
            {
                Console.WriteLine("Ingrese una Numero para operar:");
                int a = 0;
                string? s1 = Console.ReadLine();
                bool result1 = int.TryParse(s1, out a); //a=numerico
                if (result1)
                {
                    string ms = "";
                    switch (op)
                    {
                        case 1:
                            ms = +Calc.Resultado + " + " + a;
                            Calc.Sumar(a);
                            break;
                        case 2:
                            ms = +Calc.Resultado + " - " + a;
                            Calc.Restar(a);
                            break;
                        case 3:
                            ms = +Calc.Resultado + " * " + a;
                            Calc.Multiplicar(a);
                            break;
                        case 4:
                            if (a != 0)
                            {
                                ms = +Calc.Resultado + " / " + a;
                            }
                            else
                            {
                                ms = "No se puede dividir  " + Calc.Resultado + " con " + a;
                            }
                            Calc.Dividir(a);
                            break;
                    }
                    if (a==0)
                    {
                        Console.WriteLine(ms);
                    }
                    Console.WriteLine(ms+" =  "+Calc.Resultado.ToString());
                }
                else
                {
                        Console.WriteLine("Valor ingresado del numero es invalido.");
                        Calc.Limpiar();
                        op = 0;
                
                }
            }
            switch (op)
            {
                case 6:
                Calc.MostrarHistorial();
                    break;
                case 5:
                Calc.Limpiar();
                Console.WriteLine("Historial fue limpiado con exito.");
                    break;
            }
            Console.WriteLine("Desea realizar otra Operacion?.");
            Console.WriteLine("1. si");
            Console.WriteLine("0. no");
            string? p = Console.ReadLine();
            bool resulp = int.TryParse(p, out op); //op=numerico

            if (!resulp || op != 1)
            {
                if (op == 0)
                {
                    Console.WriteLine("Saliendo...");
                    Calc.Limpiar();
                }
                else
                {
                    Console.WriteLine("valor ingresado para realizar una operacion es invalido.");
                    Calc.Limpiar();
                    op = 0;
                }
            }
        }
    }
    else
    {
        Console.WriteLine("valor ingresado para realizar una operacion es invalido.");
        Calc.Limpiar();
        op = 0;
    }
} while (op != 0);