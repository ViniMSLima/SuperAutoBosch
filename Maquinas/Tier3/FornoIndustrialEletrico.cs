using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class FornoIndustrialEletrico : Maquina
{

    public FornoIndustrialEletrico()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 3;
        this.Ataque = 4;
        this.Vida = 3;

        this.Nome = "Forno Industrial Eletrico";
    }
}