using UnityEngine;

public abstract class AKeyHandler : AReaction
{
    public abstract KeyCode inputKey { get; }
    public VariableReaction reactions;

    public override void React()
    {
        reactions.React();
    }
}