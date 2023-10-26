public class ListaBase
{
    public static void IniciarListaBase()
    {
        Martelo martelo = new();
        ChaveDeFenda chaveDeFenda = new();
        Esteira esteira = new();
        Furadeira furadeira = new();

        FureadeiraDeColuna fureadeiraDeColuna = new();
        FornoIndustrialAGas fornoIndustrialAGas = new();
        RetificaPlana retificaPlana = new();

        FuredeiraDeCoordenada furadeiraDeCoordenada = new();
        FornoIndustrialEletrico fornoIndustrialEletrico = new();
        RetificaCilindrica retificaCilindrica = new();
        JetCutting jetCutting = new();

        Fresa fresa = new();
        Torno torno = new();

        TornoCNC tornoCNC = new();
        FresaCNC fresaCNC = new();
        
        CorteAPlasmaCNC corteAPlasmaCNC = new();

        Jogo.listaBaseMaquinas.Add(martelo);
        Jogo.listaBaseMaquinas.Add(chaveDeFenda);
        Jogo.listaBaseMaquinas.Add(esteira);
        Jogo.listaBaseMaquinas.Add(furadeira);

        Jogo.listaBaseMaquinas.Add(fureadeiraDeColuna);
        Jogo.listaBaseMaquinas.Add(fornoIndustrialAGas);
        Jogo.listaBaseMaquinas.Add(retificaPlana);

        Jogo.listaBaseMaquinas.Add(furadeiraDeCoordenada);
        Jogo.listaBaseMaquinas.Add(fornoIndustrialEletrico);
        Jogo.listaBaseMaquinas.Add(retificaCilindrica);
        Jogo.listaBaseMaquinas.Add(jetCutting);

        Jogo.listaBaseMaquinas.Add(fresa);
        Jogo.listaBaseMaquinas.Add(torno);

        Jogo.listaBaseMaquinas.Add(tornoCNC);
        Jogo.listaBaseMaquinas.Add(fresaCNC);

        Jogo.listaBaseMaquinas.Add(corteAPlasmaCNC);

        Jogo.meuTime.Insert(0, null);
        Jogo.meuTime.Insert(1, null);
        Jogo.meuTime.Insert(2, null);
        Jogo.meuTime.Insert(3, null);
        Jogo.meuTime.Insert(4, null);
    }
}