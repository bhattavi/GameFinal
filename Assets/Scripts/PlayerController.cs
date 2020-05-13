using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 8.0f;
    public ParticleSystem bullet1;
    public ParticleSystem bullet2;
    public ParticleSystem bullet3;
    public ParticleSystem destroy;
    public static float score;
    public Text scoreText;
    AudioSource audioSource;
    public AudioClip death;
    public AudioClip bullets;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();
        MoveVertical();
        PlayerRotation();
        BulletFire();
        scoreText.text = score.ToString();
    }

    private void MoveVertical()
    {
       
        float VerticalThrow = Input.GetAxis("Vertical");
        float yOffSet = VerticalThrow * speed * Time.deltaTime;
        Vector3 localPos = transform.localPosition;
        float moveVertical = Mathf.Clamp(localPos.y + yOffSet, -3f, 3f);
        localPos = new Vector3(localPos.x, moveVertical, localPos.z);
        transform.localPosition = localPos;
    }

    private void MoveHorizontal()
    {
    
        float horizontalThrow = Input.GetAxis("Horizontal");
        float xOffSet = horizontalThrow *speed * Time.deltaTime;
        Vector3 localPos = transform.localPosition;
        float moveHorizontal = Mathf.Clamp(localPos.x + xOffSet, -3.5f, 3.5f);
        localPos = new Vector3(moveHorizontal, localPos.y, localPos.z);
        transform.localPosition = localPos;
    }
    private void PlayerRotation()
    {
        float pitch = transform.localPosition.y * -5.0f;
        float yaw = transform.localPosition.x * 5.0f;
        float roll = transform.localPosition.z * 0.0f;
        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }
    private void BulletFire()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            audioSource.PlayOneShot(bullets);
            bullet1.Play();
            bullet2.Play();
            bullet3.Play();
        }
        else
        {
            bullet1.Pause();
            bullet2.Pause();
            bullet3.Pause();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            audioSource.PlayOneShot(death);

            SceneManager.LoadScene("LoseWinScene");
           

            Debug.Log("got hit");
           
            destroy.Play();
            //audio.Play();
            // Destroy(this.gameObject, 5f);
        }
     
    }

}
