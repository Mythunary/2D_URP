using UnityEngine;

public class TimeReceptor : MonoBehaviour
{
    public TimeInstanceListVariable instances;

    private void Update()
    {
        CheckTriggerTimesRecursively();
    }

    void CheckTriggerTimesRecursively()
    {
        if(instances.list.Count > 0)
        {
            if (instances.list[0].triggerTime.value <= Time.realtimeSinceStartup)
            {
                instances.list[0].reaction.React();
                instances.list.RemoveAt(0);
                CheckTriggerTimesRecursively();
            }
        }
    }
}