using UnityEngine;

public class AddNewTimeInstance : AReaction
{
    public TimeInstance newInstance;
    public TimeInstanceListVariable instances;
    bool instanceFit = false;

    public override void React()
    {
        newInstance.triggerTime.value = Time.realtimeSinceStartup + newInstance.duration.value;
        
        if(instances.list.Count > 0)
        {
            for (int i = 0; i < instances.list.Count; i++)
            {
                if (instances.list[i].triggerTime.value >= newInstance.triggerTime.value)
                {
                    instances.list.Insert(i, newInstance);
                    instanceFit = true;
                    break;
                }
            }
            if(instanceFit == false)
            {
                instances.list.Add(newInstance);
            }
            instanceFit = false;
        }
        else
        {
            instances.list.Add(newInstance);
        }
    }
}