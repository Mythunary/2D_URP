using UnityEngine;

public class KeyboardInputReceptor : MonoBehaviour
{
    public AKeyHandlerArrayVariable keysDown;
    public AKeyHandlerArrayVariable keysUp;
    
    private void Update()
    {        
        if (Input.anyKeyDown)
        {
            for (int i = 0; i < keysDown.array.Length; i++)
            {
                if (Input.GetKeyDown(keysDown.array[i].inputKey))
                {
                    keysDown.array[i].React();
                }
            }
        }        
        for (int i = 0; i < keysUp.array.Length; i++)
        {
            if (Input.GetKeyUp(keysUp.array[i].inputKey))
            {
                keysUp.array[i].React();
            }
        }
    }
}