internal class Personagem{
    protected string nome;
    protected int forca;
    protected int inteligencia;
    protected int vida;
    protected int vidaAtual;

    public Personagem(string nome, int forca, int inteligencia, int vida){
        this.nome = nome;
        this.forca = forca;
        this.inteligencia = inteligencia;
        this.vida = vida;
        this.vidaAtual = vida;
    }

    public void atacar(Personagem alvo){
        int dano = forca/2;
        Console.WriteLine(this.nome + " atacou " + alvo.nome + ", causando " + dano + " de dano.");
        alvo.receberDano(dano);
    }


    protected void receberDano(int dano){
        this.vidaAtual -= dano;
        if(this.vidaAtual <= 0){
            Console.WriteLine(this.nome + " morreu");
        }else{
            Console.WriteLine(this.nome + " sobreviveu com " + this.vidaAtual + " de vida.");
        }
    }

    public virtual void descricao(){
        Console.WriteLine("Nome:" + this.nome);
        Console.WriteLine("Força:" + this.forca);
        Console.WriteLine("Inteligencia:" + this.inteligencia);
        Console.WriteLine("Vida:" + this.vida + "/" + this.vidaAtual);
    }

    

}