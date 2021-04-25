using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastForce : MonoBehaviour
{

    public float Speed = 10f;
    private Rigidbody Blast;
    // Start is called before the first frame update
    void Start()
    {
        Blast = gameObject.GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
