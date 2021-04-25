using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    public GameObject Blast;
    public GameObject BlastHole;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
       {
           //If Mouse pressed, Blast weapon
           Instantiate(Blast, new Vector3 (BlastHole.transform.position.x, BlastHole.transform.position.y, BlastHole.transform.position.z), Quaternion.Euler(0,0,0));
       } 
    }
}
