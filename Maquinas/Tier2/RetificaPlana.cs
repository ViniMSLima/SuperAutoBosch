using System.Diagnostics.Contracts;

public class RetificaPlana : Maquina
{

    public RetificaPlana()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 2;
        this.Ataque = 4;
        this.Vida = 2;

        this.Nome = "Retifica Plana ";
    }

    public override void Derrotado()
    {
        // Ao morrer concede +1 / +1 a dois aliados atrás
        Jogo.meuTime[0].Vida++;
        Jogo.meuTime[0].Ataque++;

        Jogo.meuTime[1].Vida++;
        Jogo.meuTime[1].Ataque++;

    }
}
