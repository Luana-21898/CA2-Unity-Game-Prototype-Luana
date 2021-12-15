using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject g = Instantiate(bulletPrefab, transform.position, transform.parent.rotation);

            float force = g.GetComponent<Bullet>().speed; //access bullet script and get speed

            g.GetComponent<Rigidbody>().AddForce(g.transform.forward * force);//access rigidbody, add forward force
        }

        
    }
}
