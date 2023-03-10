internal class Mago : Personagem{

    private int mana;

    public Mago(string nome, int forca, int inteligencia, int vida) : base(nome, forca, inteligencia, vida)
    {
        this.nome = nome;
        this.forca = forca;
        this.inteligencia = inteligencia;
        this.vida = vida;
        this.vidaAtual = vida;
        this.mana = inteligencia;
    }

    public override void descricao(){
        Console.WriteLine("Nome:" + this.nome);
        Console.WriteLine("Força:" + this.forca);
        Console.WriteLine("Inteligencia:" + this.inteligencia);
        Console.WriteLine("Vida:" + this.vida + "/" + this.vidaAtual);
        Console.WriteLine("Mana:" + this.mana);
    }

}