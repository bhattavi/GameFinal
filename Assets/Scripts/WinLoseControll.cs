using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class WinLoseControll : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject win;
    public GameObject lose;
    public Text scoreText;

    void Start()
    {
        win.SetActive(false);
        lose.SetActive(false);

        if (GameData.count == 1) //when the airplane sccessfully passes level 3, count +1
        {
            
            win.SetActive(true);
            lose.SetActive(false);
        }
        else if (GameData.count == 0)
        {
           
            win.SetActive(false);
            lose.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = PlayerController.score.ToString();
        if (Input.GetKey(KeyCode.Space))
        {
            PlayerController.score = 0.0f;
            SceneManager.LoadScene("Menu");
            Destroy(GameObject.Find("Music"));
            GameData.count = 0;
        }
    }
}
