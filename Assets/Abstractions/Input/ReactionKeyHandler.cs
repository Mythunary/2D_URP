using UnityEngine;

public class ReactionKeyHandler : AReactionComposite
{
    public KeyCode reactionKey;
    public AReactionCompositeVariable controlFlowReaction;
    public AReactionComposite reactiveBehaviour;

    public override void React()
    {
        controlFlowReaction.value = reactiveBehaviour;
    }
}