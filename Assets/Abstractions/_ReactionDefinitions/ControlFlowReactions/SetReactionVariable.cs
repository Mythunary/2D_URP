public class SetReactionVariable : AReaction
{
    public AReactionVariable controlReaction;
    public AReaction newReaction;

    public override void React()
    {
        controlReaction.value = newReaction;
    }
}