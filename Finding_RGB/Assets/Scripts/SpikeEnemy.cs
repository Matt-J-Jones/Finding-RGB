using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public bool PlayerInTrigger = false;
    public Item DeadPlayer;
    public Item Player;
    
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInTrigger)
        {
            Player.gameObject.SetActive(false);
            DeadPlayer.gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other) // Player has entered collider
    
    {
      if (other.CompareTag("Player"))
      {
        PlayerInTrigger = true; //Set variable
      }
    }

    void OnTriggerExit2D(Collider2D other) // Player leaves collider
    {
      if (other.CompareTag("Player"))
      {
        PlayerInTrigger = false; //unset variable
      }
    }
}
