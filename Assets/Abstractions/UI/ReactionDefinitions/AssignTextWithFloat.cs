public class AssignTextWithFloat : AUIReaction
{
    public FloatVariable floatData;
    public StringVariable textData;
    public AReactionComposite updateTextReaction;

    public override void React()
    {
        textData.value = floatData.value.ToString();
        updateTextReaction.React();
    }
}
