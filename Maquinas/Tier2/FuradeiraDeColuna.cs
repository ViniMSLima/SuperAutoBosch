using System.Diagnostics.Contracts;

public class FureadeiraDeColuna : Maquina
{

    public FureadeiraDeColuna()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 2;
        this.Ataque = 3;
        this.Vida = 5;

        this.Nome = "Fureadeira De Coluna";
    }

    public override void FimAtaque()
    {
        //Removar um de vida do aliado atrás
        Jogo.meuTime[1].Vida--;
    }

}
