public class ReactVariableReaction : AReaction
{
    public AReactionVariable reaction;

    public override void React()
    {
        reaction.value.React();
    }
}