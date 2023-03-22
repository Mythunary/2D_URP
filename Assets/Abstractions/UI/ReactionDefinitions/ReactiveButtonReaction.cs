public class ReactiveButtonReaction : AUIReaction
{
    public AReactionCompositeVariable controlFlowReaction;

    public override void React()
    {
        controlFlowReaction.value.React();
    }
}