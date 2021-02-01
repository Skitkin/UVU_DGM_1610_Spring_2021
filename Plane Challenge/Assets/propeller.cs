using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propeller : MonoBehaviour
{
    public float rotationSpeed = 1e+07f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          transform.Rotate(Vector3.forward, rotationSpeed * 1 * Time.deltaTime);
    }
}
