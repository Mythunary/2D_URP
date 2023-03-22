using UnityEngine;

public class InputKeyHandler : AReactionComposite
{
    public KeyCode inputKey;
    public AReactionCompositeVariable controlFlowReaction;

    public override void React()
    {
        controlFlowReaction.value.React();
    }
}