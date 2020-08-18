using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Config")]

public class Config : ScriptableObject
{

    [SerializeField] int minPartySize = 2;
    [SerializeField] int maxPartySize = 4;

    public int GetMinPartySize()
    {
        return minPartySize;
    }
    public int GetMaxPartySize()
    {
        return maxPartySize;
    }
}
