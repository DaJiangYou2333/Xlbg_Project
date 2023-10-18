using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class AutoInteract : Interactable
{
    public override void Interact()
    {

        Debug.Log("Auto interacting with " + gameObject.name);
    }

    void Update()
    {
    }

    private new void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            isInRange = true;
            Debug.Log("Player now in range");
            Interact(); 
        }
    }

}