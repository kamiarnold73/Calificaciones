namespace Calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitar calificación
            Console.WriteLine("Ingrese la calificación: ");
            int calificación = int.Parse(Console.ReadLine());

            //Verificar si la calificación es aprobatoria o no
            if (calificación >= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"La calificación es {calificación}, aprobada");
            }
            else if (calificación > 50)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"La calificación es {calificación}, reprobada con derecho a regularizar");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"La calificación es {calificación}, reprobada, debe volver a cursar");
            }

            Console.ResetColor();
        }
    }
}






