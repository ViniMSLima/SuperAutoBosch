using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Serialization;

public class Jogo
{

    public State State { get; set; }

    public static int Dinheiros { get; set; }
    public static int Coracoes { get; set; }
    public static int Trofeus { get; set; }
    public static int Rodada { get; set; }

    public static List<Maquina> meuTime = new();

    public static List<Maquina> timeInimigo = new();

    public static List<Maquina> listaBaseMaquinas = new();
    public static Loja lojaAmigo = new();
    public static Loja lojaInimigo = new();

    public void Act()
    {
        this.State.Act();
    }

    public void Inicializar()
    {

        Coracoes = 5;
        Trofeus = 0;
        Rodada = 0;
        Dinheiros = 10;

        ListaBase.IniciarListaBase();

        lojaAmigo.Preencher();

        MessageBox.Show("Loja preenchida");

    }

    public void PreencherInimigo()
    {
        lojaInimigo.Preencher();

        for(int i = 0; i < 3; i++)
        {
            if (timeInimigo[i] is null)
            {
                var random = new Random();
                int index = random.Next(lojaInimigo.Tamanho());
                timeInimigo.Insert(i, lojaInimigo.loja[index]);
            }

            foreach(Maquina m in timeInimigo)
            {
                if(m.Nome == lojaInimigo.loja[i].Nome)
                {
                    timeInimigo.Insert(i, lojaInimigo.loja[i]);
                }
            }

        }
    }

    public void Batalha()
    {
        Rodada++;
        
        if(Rodada == 3 && Coracoes < 5)
            Coracoes++;

        var Amigo = new Stack<Maquina>(meuTime);
        var Inimigo = new Stack<Maquina>(timeInimigo);

        PreencherInimigo();

        while (true)
        {
            
            Amigo.Peek().Vida -= Inimigo.Peek().Ataque;
            Inimigo.Peek().Vida -= Amigo.Peek().Ataque;

            if (Amigo.Peek().Vida < 1)
                Amigo.Pop();
            
            if (Inimigo.Peek().Vida < 1)
                Inimigo.Pop();
            
            if (Amigo is null && Inimigo is null)
            {
                MessageBox.Show("Empate" +
                                "\nTrofeus: " + Trofeus + 
                                "\nCoracoes: " + Coracoes + 
                                "\nRodada: " + Rodada);
                break;
            }

            if(Amigo is null)
            {
                Coracoes--;
                MessageBox.Show("Derrota" +
                                "\nTrofeus: " + Trofeus +
                                "\nCoracoes: " + Coracoes + 
                                "\nRodada: " + Rodada);
                break;
            }

            if(Inimigo is null)
            {
                Trofeus++;
                MessageBox.Show("Vitoria" +
                                "\nTrofeus: " + Trofeus +
                                "\nCoracoes: " + Coracoes + 
                                "\nRodada: " + Rodada);
                break;
            }

            if(Trofeus == 10)
            {
                MessageBox.Show("Parabéns, você ganhou!!" +
                                "\nTrofeus: " + Trofeus +
                                "\nCoracoes: " + Coracoes + 
                                "\nRodada: " + Rodada);
                Application.Exit();
            }

            if(Coracoes == 0)
            {
                MessageBox.Show("Você perdeu!!" +
                                "\nTrofeus: " + Trofeus +
                                "\nCoracoes: " + Coracoes + 
                                "\nRodada: " + Rodada);
                Application.Exit();
            }
        }
    }
}

