using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class Fresa : Maquina
{

    public Fresa()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 4;
        this.Ataque = 4;
        this.Vida = 5;

        this.Nome = "Fresa";
    }
}