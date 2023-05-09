public class SetNewPotentialTile : AReaction
{
    public GameObjectVariable potentialInsertTile;
    public AGameObjectOutReaction deliverRandomTile;
    public BoolVariable newHexInserted;

    public override void React()
    {
        if(newHexInserted.value == false)
        {
            Destroy(potentialInsertTile.value);
        }
        potentialInsertTile.value = deliverRandomTile.React();
    }
}