using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class RetificaCilindrica : Maquina
{

    public RetificaCilindrica()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 3;
        this.Ataque = 2;
        this.Vida = 6;

        this.Nome = "Retifica Cilindrica";
    }

    public override void Machucado()
    {
        //Ao se machucar (e ficar vivo) da +1/+1 ao aliado atrás.
            Jogo.meuTime[1].Vida++;
            Jogo.meuTime[1].Ataque++;
    }
}