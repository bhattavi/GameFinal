using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        Invoke("LoadScene", 3.0f);
    }

 void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
