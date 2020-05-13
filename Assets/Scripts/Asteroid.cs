using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public GameObject destroy;
    private void OnParticleCollision(GameObject other)
    {
        PlayerController.score += 5.0f;
        Instantiate(destroy, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        
    }
}
