using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public Item Fade;
    
    // Start is called before the first frame update
    void Start()
    {
        Fade.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
