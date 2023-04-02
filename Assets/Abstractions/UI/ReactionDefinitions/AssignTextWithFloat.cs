public class AssignTextWithFloat : AReaction
{
    public FloatVariable floatData;
    public StringVariable textData;
    public AReaction updateTextReaction;

    public override void React()
    {
        textData.value = floatData.value.ToString();
        updateTextReaction.React();
    }
}
