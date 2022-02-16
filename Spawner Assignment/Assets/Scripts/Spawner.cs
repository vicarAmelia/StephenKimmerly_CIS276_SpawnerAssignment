using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   public GameObject cannonball;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject ball;
            ball = Instantiate(cannonball, transform);

            ball.GetComponent<Rigidbody>().AddForce(Vector3.forward * 30f, ForceMode.Impulse);
        }
    }
}
