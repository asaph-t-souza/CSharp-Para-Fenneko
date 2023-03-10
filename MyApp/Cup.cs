internal class Cup{
    private int tamanho;
    private int liquido;

    public Cup(int tamanho){
        this.tamanho = tamanho;
        this.liquido = 0;
    }

    public Cup(string tipo){
        if(tipo == "pinga"){
            this.tamanho = 50;
            this.liquido = 0;
        }else if(tipo == "americano"){
            this.tamanho = 190;
            this.liquido = 0;
        }else{
            this.tamanho = 300;
            this.liquido = 0;
        }
    }

    public void encher(int liquido){
        if(liquido < 0){
            return;
        }

        int liquidoTotal = this.liquido + liquido;

        if(liquidoTotal > this.tamanho){
            this.liquido = this.tamanho;
        }else{
            this.liquido = liquidoTotal;
        }
    }

    public void esvaziar(){
        Console.WriteLine("Derramou um total de: " + this.liquido);
        this.liquido = 0;
    }

    public void esvaziar(int remover){
        if(remover < 0){
            return;
        }

        if(remover > this.liquido){
            Console.WriteLine("Derramou um total de: " + this.liquido);
            this.liquido = 0;
        }else{
            Console.WriteLine("Derramou um total de: " + remover);
            this.liquido -= remover;     
        }


    }

    public string descricao(){
        return(
            "Esse copo tem " + this.tamanho + "ml de tamanho," +
            "e contem " + this.liquido + "ml de liquido"
        );
    }


}