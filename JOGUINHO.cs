using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
 
public class JOGUINHO : App
{
    bool fundiu = false;
    bool clicked = false;
    RectangleF meuTime1, meuTime2 = RectangleF.Empty;

    Jogo jogo = new();

    public override void OnFrame(bool isDown, PointF cursor)
    {

        var builder = new StateBuilder();

        builder
            .AddLoja()
            .AddBatalha()
            .Build();

        Rectangle rect = new Rectangle(10, 10, 130, 140);

        int x = 100;
        int y = 800;

        foreach(Maquina m in Jogo.lojaAmigo.loja)
        {
            if (m != null)
                DrawPiece(new RectangleF(x, y, 200, 200), m.Ataque, m.Nivel, m.Vida, m.Tier, true, m.Nome);
            x += 200;
        }

        if (meuTime1.Contains(cursor) && meuTime2.Contains(cursor) && !isDown)
            fundiu = true;
 
        if (!fundiu)
        {
            x = 100;
            y = 400;

            foreach(Maquina m in Jogo.meuTime)
            {
                if (m != null)
                    DrawPiece(new RectangleF(x, y, 200, 200), m.Ataque, m.Nivel, m.Vida, m.Tier, true, m.Nome);
                x += 200;
            }

        }
        else
        {
            meuTime1 = DrawPiece(new RectangleF(50, 50, 200, 200), 3, 5, 3, 1, true, "SUPER CNC");
        }
 
        if (!clicked)
        {
            clicked = DrawButton(new RectangleF(850, 800, 200, 100), "Iniciar");
            if (clicked)
            {
                jogo.Inicializar();
            }
                
        }
    }
}