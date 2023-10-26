public class StateBuilder
{
    public Jogo jogo = null;
    public State firstState = null;
    public State lastState = null;

    public StateBuilder SetJogo(Jogo jogo)
    {
        this.jogo = jogo;
        return this;
    }

    public StateBuilder AddState(State state)
    {
        state.jogo = this.jogo;
        if (lastState is not null)
            lastState.NextState = state;

        if (firstState is null)
            firstState = state;

        lastState = state;

        return this;
    }

    public State Build()
    {
        lastState.NextState = firstState;

        this.jogo.State = firstState;
        return firstState;
    }
}

public static class StateBuilderExtensions
{
    public static StateBuilder AddLoja(this StateBuilder builder)
    {
        builder.AddState(new LojaState());
        return builder;
    }

    public static StateBuilder AddBatalha(this StateBuilder builder)
    {
        builder.AddState(new BatalhaState());
        return builder;
    }

}