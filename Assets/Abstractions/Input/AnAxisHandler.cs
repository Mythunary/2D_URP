public abstract class AnAxisHandler : AFloatInReaction
{
    public abstract string axisName { get; }
    public FloatInVariableReaction reaction;
    
    public override void React(float value)
    {
        reaction.React(value);
    }
}