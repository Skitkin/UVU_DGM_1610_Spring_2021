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

    //Destroy Bullets after a certian amount of time

        StartCoroutine(Die());
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    //If Blast touches enemy, Destroy Enemy
    void OnTriggerEnter(Collider other)
    {
        Debug.Log (other.gameObject.name);
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }

    }

     IEnumerator Die()
     {
         yield return new WaitForSeconds(3);

         Destroy (gameObject);
     }
}
