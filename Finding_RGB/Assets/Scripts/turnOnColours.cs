using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnColours : MonoBehaviour
{
    public string Tag;
    public Color newColour;
    SpriteRenderer Sprite;
    void Start()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(Tag);
        foreach (GameObject go in objects)
        {
        SpriteRenderer[] renderers = go.GetComponents<SpriteRenderer>();
            foreach (SpriteRenderer r in renderers) 
            {
            r.color = newColour;
            }

        }
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
