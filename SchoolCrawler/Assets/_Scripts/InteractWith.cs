using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class InteractWith : MonoBehaviour
{
    [SerializeField]
    private TextAsset DialogueAsset;

    private List<string> dialogue;

    private int lineToRead = 0;

    void Start()
    {
        string lines = DialogueAsset.text;
        dialogue = new List<string>();

        foreach (var line in lines.Split('\n')) 
        {
            dialogue.Add(line);
        }
    }

    void OnInteract()
    {
        if (dialogue.Count > lineToRead)
        {
            Debug.Log(dialogue[lineToRead]);
            lineToRead++;
        }
        else
        {
            Debug.Log(dialogue[dialogue.Count - 1]);
        }
    }
}
