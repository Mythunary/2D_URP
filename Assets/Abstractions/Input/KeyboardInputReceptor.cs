using UnityEngine;

//OPTIMIZATION: Use Dictionary instead of for loops
public class KeyboardInputReceptor : MonoBehaviour
{
    public ReactionKeyHandler[] keyReactionsDown;
    public InputKeyHandler[] keyInputsDown;

    public ReactionKeyHandler[] keyReactionsUp;
    public InputKeyHandler[] keyInputsUp;

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            for (int i = 0; i < keyReactionsDown.Length; i++)
            {
                if (Input.GetKeyDown(keyReactionsDown[i].reactionKey))
                {
                    keyReactionsDown[i].React();
                }
            }
            for (int i = 0; i < keyInputsDown.Length; i++)
            {
                if (Input.GetKeyDown(keyInputsDown[i].inputKey))
                {
                    keyInputsDown[i].React();
                }
            }
        }
        for (int i = 0; i < keyReactionsUp.Length; i++)
        {
            if (Input.GetKeyUp(keyReactionsUp[i].reactionKey))
            {                
                keyReactionsUp[i].React();
            }
        }
        for (int i = 0; i < keyInputsUp.Length; i++)
        {
            if (Input.GetKeyUp(keyInputsUp[i].inputKey))
            {
                keyInputsUp[i].React();
            }
        }        
    }
}
