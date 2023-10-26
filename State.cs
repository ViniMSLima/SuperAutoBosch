using System.Security.Policy;

public abstract class State
{
    public State NextState { get; set; }
    public Jogo jogo;

    public virtual void Act()
    {
        this.jogo.State = NextState;
    }
}




public class LojaState : State
{
    public override void Act()
    {
        this.jogo.State = NextState;
    }
}


public class BatalhaState : State
{
    public override void Act()
    {
        this.jogo.State = NextState;
        
    }
}