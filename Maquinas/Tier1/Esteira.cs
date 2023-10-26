// using System.Diagnostics.Contracts;

public class Esteira : Maquina
{
    public Esteira()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 1;
        this.Ataque = 3;
        this.Vida = 1;

        this.Nome = "Esteira";

    }

    public override void Vendido()
    {
        Jogo.Dinheiros++;
    }

}
