public class ReactiveButtonReaction : AReaction
{
    public AReactionVariable controlFlowReaction;

    public override void React()
    {
        controlFlowReaction.value.React();
    }
}