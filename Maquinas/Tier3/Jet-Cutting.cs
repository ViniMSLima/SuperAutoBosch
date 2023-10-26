using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class JetCutting : Maquina
{

    public JetCutting()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 3;
        this.Ataque = 6;
        this.Vida = 3;

        this.Nome = "Jet-Cutting";
    }
}