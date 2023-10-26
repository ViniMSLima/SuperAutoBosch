using System;
using System.Diagnostics.Contracts;

public class Furadeira : Maquina
{
    public Furadeira()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 1;
        this.Ataque = 2;
        this.Vida = 1;

        this.Nome = "Furadeira";
    }

    public override void Derrotado()
    {
        var random = new Random();
        int index = random.Next(Jogo.meuTime.Count);

        Jogo.meuTime[index].Ataque += 2;
        Jogo.meuTime[index].Vida++;
    }
}
