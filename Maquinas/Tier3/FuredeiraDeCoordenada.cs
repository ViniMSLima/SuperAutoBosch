using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class FuredeiraDeCoordenada : Maquina
{

    public FuredeiraDeCoordenada()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 3;
        this.Ataque = 3;
        this.Vida = 5;

        this.Nome = "Furedeira De Coordenada";
    }

    public override void Machucado()
    {
        var random = new Random();
        int index = random.Next(Jogo.timeInimigo.Count);
        Jogo.timeInimigo[index].Vida--;  
    }
}
