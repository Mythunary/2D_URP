public class ReactionContainer : AReactionComposite
{
    public AReactionComposite[] reactions;

    public override void React()
    {
        for (int i = 0; i < reactions.Length; i++)
        {
            reactions[i].React();
        }
    }
}
