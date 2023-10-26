using System.Diagnostics.Contracts;

public class FresaCNC : Maquina
{

    public FresaCNC()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 5;
        this.Ataque = 8;
        this.Vida = 4;

        this.Nome = "Fresa CNC";
    }

}
