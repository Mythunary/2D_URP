using UnityEngine;

public class AddGameObjectToArray : AGameObjectInReaction
{
    public GameObjectArrayVariable array;
    GameObject[] newArray;

    public override void React(GameObject gameObject)
    {
        newArray = new GameObject[array.array.Length + 1];
        for (int i = 0; i < array.array.Length; i++)
        {
            newArray[i] = array.array[i];
        }
        array.array[newArray.Length - 1] = gameObject;
    }
}