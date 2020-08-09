using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] int characterIndex;

    // Cache
    GameSettings gameSettings;
    private void Start()
    {
        gameSettings = FindObjectOfType<GameSettings>();
    }

    public void SetCharacterName(string characterName)
    {
        gameSettings.SetCharacterName(characterIndex, characterName);
    }
}
