using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityMod;
    public bool isOnGround = true;
    public bool isGameOver =false;
    public float Movementspeed = 80;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();  
        Physics.gravity *= gravityMod; 

    
    } 
        

    // Update is called once per frame
    void Update()
    {
        // Movement for left and right

        var x = Input.GetAxis("Horizontal");

        var y = Input.GetAxis("Vertical");
         transform.Translate(Vector3.forward * x * Time.deltaTime * Movementspeed);

        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
            isOnGround = false;

           
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        

        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            

        }        
        }
    }
