public class UseNewDropdownOption : AUIReaction
{
    public IntVariable data;
    public StringVariable textData;
    public StringArrayVariable options;
    public AReactionComposite setText;

    public override void React()
    {
        textData.value = options.array[data.value];
        setText.React();
    }
}
