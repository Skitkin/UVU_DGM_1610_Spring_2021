using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlast : MonoBehaviour
{
  public float speed = 50.0f; 
  public GameObject gunPoint;
  public Vector3 blastVector;
  

    // Start is called before the first frame update
    void Start()
    {
        gunPoint = GameObject.Find("GameObject");

        blastVector = gunPoint.transform.forward;
    }

    // Update is called once per frame
    void Update()


    // make bullets fly 
    {
         transform.Translate(blastVector * Time.deltaTime * speed);
    }

    void OnCollisionEnter( Collision collision)
    {
        Destroy(gameObject);
    }
    
}