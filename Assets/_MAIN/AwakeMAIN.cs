using UnityEngine;

public class AwakeMAIN : MonoBehaviour
{
    public AReactionArrayVariable awakes;

    public void Awake()
    {
        for (int i = 0; i < awakes.array.Length; i++)
        {
            awakes.array[i].React();
        }
    }
}
