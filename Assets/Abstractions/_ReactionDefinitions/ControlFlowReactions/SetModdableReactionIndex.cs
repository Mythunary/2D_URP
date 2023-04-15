public class SetModdableReactionIndex : AReaction
{
    public IntVariable index;
    public BoolVariable[] moddableStates;

    public override void React()
    {
        index.value = 0;
        for (int i = 0; i < moddableStates.Length; i++)
        {
            if (moddableStates[i].value == true)
            {                
                index.value |= 1 << i;
            }
        }
    }
}