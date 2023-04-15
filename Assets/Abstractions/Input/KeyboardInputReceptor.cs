using UnityEngine;

public class KeyboardInputReceptor : MonoBehaviour
{
    public AKeyCodeArrayVariable keys;
    
    private void Update()
    {        
        if (Input.anyKeyDown)
        {
            for (int i = 0; i < keys.array.Length; i++)
            {
                if (Input.GetKeyDown(keys.array[i].inputKey))
                {
                    keys.array[i].status.value = true;
                    keys.array[i].reaction.React();
                }
            }
        }        
        for (int i = 0; i < keys.array.Length; i++)
        {
            if (Input.GetKeyUp(keys.array[i].inputKey))
            {
                keys.array[i].status.value = false;
                keys.array[i].reaction.React();
            }
        }
    }
}