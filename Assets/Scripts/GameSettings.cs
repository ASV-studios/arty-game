using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    [SerializeField] int partySize = 2;
    [SerializeField] bool randomSpawn = true;
    [SerializeField] Config gameConfig;

    [SerializeField] List<string> characterNames;
    [SerializeField] List<Sprite> characterModels;

    public void Start()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SetRandomSpawn(bool randomSpawn)
    {
        this.randomSpawn = randomSpawn;
    }

    public bool GetRandomSpawn()
    {
        return randomSpawn;
    }

    public void SetPartySize(string partySize)
    {
        Int32.TryParse(partySize, out this.partySize);
    }
    public int GetPartySize()
    {
        return this.partySize;
    }

    public void SetCharacterName(int characterIndex, string characterName)
    {
        characterNames[characterIndex] = characterName;
    }

    public string GetCharacterName(int characterIndex) {
        return characterNames[characterIndex];
    }
}
