using UnityEngine;
using System.Collections.Generic;

public class TimeInstanceListVariable : ScriptableObject
{
    public List<TimeInstance> list;

    private void OnDisable()
    {
        list.Clear();
    }
}