using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapLevelTrigger : MonoBehaviour
{
    public string NewScene;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(NewScene);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
