internal class Program
{
    private static void Main(string[] args)
    {
        Personagem fenneko = new Personagem("Fenneko", 15, 3, 10);
        Personagem strife = new Mago("Strife", 5, 5, 20);

        strife.descricao();
        Console.WriteLine("--------");

        strife.atacar(fenneko);

        

    }
}