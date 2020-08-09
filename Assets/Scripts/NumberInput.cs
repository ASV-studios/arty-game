using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberInput : MonoBehaviour
{
    [SerializeField] int partySize = 2;
    [SerializeField] int minPartySize = 2;
    [SerializeField] int maxPartySize = 4;
    [SerializeField] List<Character> characters;
    void Start()
    {
        UpdatePartySize();
    }
    public void ChangePartySize(int change)
    {
        this.partySize = Mathf.Clamp(this.partySize + change, minPartySize, maxPartySize);
        UpdatePartySize();
    }

    private void UpdatePartySize()
    {
        gameObject.GetComponent<TMP_InputField>().text = partySize.ToString();
        DisplayActiveCharacters();
    }


    private void DisplayActiveCharacters()
    {
        for (int i = 0; i < characters.Count; i++)
        {
            if (i < partySize)
            {
                characters[i].gameObject.SetActive(true);
            }
            else
            {
                characters[i].gameObject.SetActive(false);
            }
        }
    }
}
