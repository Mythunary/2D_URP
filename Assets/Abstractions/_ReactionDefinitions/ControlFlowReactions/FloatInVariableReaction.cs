public class FloatInVariableReaction : AFloatInReaction
{
    public AFloatInReactionVariable reaction;

    public override void React(float value)
    {
        reaction.value.React(value);
    }
}