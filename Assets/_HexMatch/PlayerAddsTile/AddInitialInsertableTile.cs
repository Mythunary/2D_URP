public class AddInitialInsertableTile : AReaction
{
    public GameObjectVariable currentActiveInsertableTile;
    public AGameObjectOutReaction deliverTile;    

    public override void React()
    {
        currentActiveInsertableTile.value = deliverTile.React();
    }
}