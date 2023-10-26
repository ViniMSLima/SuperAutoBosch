using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Serialization;

public class Loja 
{
    public List<Maquina> loja = new();

    public void Preencher()
    {
        loja.Clear();

        for(int i = 0; i < 3; i++)
        {
            var random = new Random();
            int index = random.Next(Jogo.listaBaseMaquinas.Count);
            loja.Add(Jogo.listaBaseMaquinas[index]);
        }
    }

    public int Tamanho()
        => loja.Count;
    

    public void Compra(Maquina maquina, int index) //Jogador compra uma maquina
    {
        if(Jogo.Dinheiros > 2)
        {
            loja.RemoveAt(index);
            Jogo.meuTime.Insert(index, maquina);
            Jogo.Dinheiros -= 3;
        } else {
            MessageBox.Show("Dinheiro insuficiente");
        }
    }
    
    public void Vende(int index) //Jogador vende uma maquina
    {
        Jogo.meuTime.RemoveAt(index);
        Jogo.Dinheiros++;
    }

    public void Atualizar()
    {
        Jogo.Dinheiros--;
        Preencher();
    }
}