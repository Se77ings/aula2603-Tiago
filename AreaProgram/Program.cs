namespace AreaProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Lote lote1 = new Lote(12, 20, 'E');
            Lote lote2 = new Lote(10, 20, 'B');
            lote1.calculaCodigo();
            lote2.calculaCodigo();
            Lote lote3 = lote1 + lote2;
            lote3.mostraDados();

            Lote[] vetor = lote1 / lote3;
        }
    }
}

