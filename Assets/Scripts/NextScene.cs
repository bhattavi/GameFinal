using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    // Start is called before the first frame update
    public string nextScene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Player")
        {
            Debug.Log("you win");
            SceneManager.LoadScene(nextScene);
          
        }
    }
}
