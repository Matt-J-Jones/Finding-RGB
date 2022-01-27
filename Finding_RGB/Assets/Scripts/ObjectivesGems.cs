using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivesGems : MonoBehaviour
{
    public Item BlueGem;
    public bool Blue = false;
    public Item GreenGem;
    public bool Green = false;
    public Item RedGem;
    public bool Red = false;
    public Item YellowGem;
    public bool Yellow = false;
    public bool Objective_Complete = false;
    public Item Wall_Static;
    public Item Wall_Animated;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!BlueGem.isActiveAndEnabled)
        {
            Blue = true;
        }
        if (!GreenGem.isActiveAndEnabled)
        {
            Green = true;
        }
        if (!RedGem.isActiveAndEnabled)
        {
            Red = true;
        }
        if (!YellowGem.isActiveAndEnabled)
        {
            Yellow = true;
        }
        if (Blue && Green && Red && Yellow)
        {
            Objective_Complete = true;
        }
        if (Objective_Complete)
        {
            Wall_Static.gameObject.SetActive(false);
            Wall_Animated.gameObject.SetActive(true);
        }
        
    }
}
