internal class Program
{
    private static void Main(string[] args)
    {
        bool execute = true;
        while (execute)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            try
            {

                bool run = true;
                int sum = 0;
                Console.Write($"Ingrese el Multiplicador: ");
                int multiplicador = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Ingrese el Multiplicadno: ");
                int multiplicando = Convert.ToInt32(Console.ReadLine());
                while (run)
                {
                    if (multiplicador % 2 != 0)
                    {
                        sum += multiplicando;
                    }
                    if (multiplicador == 1)
                    {
                        break;
                    }
                    multiplicador /= 2;
                    multiplicando *= 2;
                }
                Console.WriteLine($"Resultado: {sum}");
                execute = false;
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Error: {e.StackTrace}\n\nMensaje: {e.Message}");
            }
            catch (OverflowException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"El numero de entrada o salida es demasiado grande \n Mensaje: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}