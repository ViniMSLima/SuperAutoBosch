using System.Diagnostics.Contracts;

public class CorteAPlasmaCNC : Maquina
{

    public CorteAPlasmaCNC()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 6;
        this.Ataque = 6;
        this.Vida = 8;

        this.Nome = "Corte a Plasma CNC";
    }

}
