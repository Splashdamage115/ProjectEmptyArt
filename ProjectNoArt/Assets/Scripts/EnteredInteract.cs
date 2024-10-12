using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnteredInteract : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered Circle");
    }
}
