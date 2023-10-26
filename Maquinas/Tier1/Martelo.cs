using System.Diagnostics.Contracts;

public class Martelo : Maquina
{

    public Martelo()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 1;
        this.Ataque = 2;
        this.Vida = 3;

        this.Nome = "Martelo";
    }

    public override void Vendido()
    {
        foreach(Maquina M in Jogo.lojaAmigo.loja)
        {
            M.Vida++;
        }
    }

}
