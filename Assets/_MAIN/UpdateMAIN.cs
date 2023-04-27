using UnityEngine;

public class UpdateMAIN : MonoBehaviour
{
    public AReactionArrayVariable updates;

    public void Update()
    {
        for (int i = 0; i < updates.array.Length; i++)
        {
            updates.array[i].React();
        }
    }
}
