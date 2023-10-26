using System.Diagnostics.Contracts;

public class TornoCNC : Maquina
{

    public TornoCNC()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 5;
        this.Ataque = 5;
        this.Vida = 8;

        this.Nome = "Torno CNC";
    }

}
