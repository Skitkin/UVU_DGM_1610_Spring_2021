using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutof : MonoBehaviour
{
  
    // Destroy objects if touching the outer box colliders
    void OnTriggerEnter(Collider other)
    {
        Destroy (other.gameObject);
    }
}

