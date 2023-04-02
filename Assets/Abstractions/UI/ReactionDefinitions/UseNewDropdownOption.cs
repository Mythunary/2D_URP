public class UseNewDropdownOption : AReaction
{
    public IntVariable data;
    public StringVariable textData;
    public StringArrayVariable options;
    public AReaction setText;

    public override void React()
    {
        textData.value = options.array[data.value];
        setText.React();
    }
}
