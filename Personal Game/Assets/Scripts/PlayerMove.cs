using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityMod;
    public bool isOnGround = true;
    public bool isGameOver = false;
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
        Debug.Log (x);

        if (x < 0)
        {
            transform.rotation = Quaternion.Euler (0, 180, 0);
        }

        else 
        {
            transform.rotation = Quaternion.Euler (0, 0, 0);
        }

        var y = Input.GetAxis("Vertical");

        if (x < 0)
        {
            transform.Translate(Vector3.forward * -x * Time.deltaTime * Movementspeed);
        }

        else 
        {
            transform.Translate(Vector3.forward * x * Time.deltaTime * Movementspeed);
        }
         


        // makes player leap 
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
            isOnGround = false;

           
            
        }
    }
        //Makes player stick to platform when on it
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag("MovingPlatform"))
        {
        transform.parent = collision.gameObject.transform;
        }
        else
        {
            transform.parent = null;
        }
        
        
        //Makes Player stick to
        if(collision.gameObject.CompareTag("Ground")||collision.gameObject.CompareTag("MovingPlatform"))
        {
            isOnGround = true;
            
        }        
        }
    }
