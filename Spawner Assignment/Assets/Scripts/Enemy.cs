using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
       if (other.gameObject.tag == "Cannonball")
       {
           Debug.Log("-1 damage");
       }
   }
}
