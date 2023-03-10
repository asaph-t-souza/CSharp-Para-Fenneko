
namespace MyApp{

    class Cup
    {
        private int tamanho, liquido;

        public Cup(int tamanho)
        {
            this.tamanho = tamanho;
            this.liquido = 0;
        }

        public void Encher(int liquido){
            this.liquido = liquido;
        }
    }
}
