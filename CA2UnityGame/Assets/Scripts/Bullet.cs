using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2000f;
    public GameObject explosionPrefab;

    void OnCollisionEnter(Collision c) //check when bullet collides with another collider
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity); //makes a copy of the explosion at collision
        Destroy(gameObject);
    }
}
