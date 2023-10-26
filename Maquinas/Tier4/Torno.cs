using System.Diagnostics.Contracts;

public class Torno : Maquina
{

    public Torno()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 4;
        this.Ataque = 5;
        this.Vida = 3;

        this.Nome = "Torno";
    }

    public override void FimCompra()
    {
        for(int i = 0;i < Jogo.meuTime.Count; i++)
        {
            if(Jogo.meuTime[i].Nivel == 3)
            {
                this.Vida += 2;
                this.Ataque += 2;
                break;
            }
        }
    }
}
