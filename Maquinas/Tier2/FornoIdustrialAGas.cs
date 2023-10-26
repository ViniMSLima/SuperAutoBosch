public class FornoIndustrialAGas : Maquina
{
    public FornoIndustrialAGas()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 2;
        this.Ataque = 1;
        this.Vida = 3;

        this.Nome = "FornoIndustrialAGas";

    }

    public override void InicioCompra()
    {
        Jogo.Dinheiros++;
    }

}
