public class ReceiveSliderUpdate : AFloatInReaction
{
    public FloatVariable dataHolder;
    public AReactionComposite reactOnSliderUpdate;

    public override void React(float value)
    {
        dataHolder.value = value;
        reactOnSliderUpdate.React();
    }
}
