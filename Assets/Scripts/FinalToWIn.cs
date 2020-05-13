using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalToWIn : MonoBehaviour
{
    // Start is called before the first frame update
    public string SceneName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("you win");
            SceneManager.LoadScene(SceneName);
            GameData.count += 1;
        }
    }
}
