using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    // public string Tag;
    // public Color newColour;
    public bool PlayerInTrigger;
    public Item Colour_T;

    // SpriteRenderer Sprite;

    // Update is called once per frame
    void Start()
    {
      

      
    }
    
    
    void Update()
    {
        if (PlayerInTrigger)
        {
            Colour_T.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other) // Player has entered collider
    {
      PlayerInTrigger = true; //Set variable
    }

    void OnTriggerExit2D(Collider2D other) // Player leaves collider
    {
      PlayerInTrigger = false; //unset variable
    }
}
