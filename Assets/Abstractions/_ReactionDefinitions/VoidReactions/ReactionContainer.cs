public class ReactionContainer : AReaction
{
    public AReaction[] reactions;

    public override void React()
    {
        for (int i = 0; i < reactions.Length; i++)
        {
            reactions[i].React();
        }
    }
}
