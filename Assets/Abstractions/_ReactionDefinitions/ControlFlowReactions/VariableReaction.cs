public class VariableReaction : AReaction
{
    public AReactionVariable reaction;

    public override void React()
    {
        reaction.value.React();
    }
}