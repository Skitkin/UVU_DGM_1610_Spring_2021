using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityMod;
    public bool isOnGround = true;
    public bool isGameOver =false;

    private Animator playerAnim;

<<<<<<< HEAD
=======

>>>>>>> main
    public ParticleSystem dirtParticles;
    public ParticleSystem explosionParticles;

    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;

<<<<<<< HEAD
=======

>>>>>>> main
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();  
        Physics.gravity *= gravityMod; 

        playerAnim = GetComponent<Animator>();
<<<<<<< HEAD
        playerAudio = GetComponent<AudioSource>();
=======

        playerAudio = GetComponent<AudioSource>();


>>>>>>> main
    } 
        

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
            isOnGround = false;

            playerAnim.SetTrigger("Jump_trig");
<<<<<<< HEAD
            dirtParticles.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f );
=======

            dirtParticles.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f );


>>>>>>> main
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        

        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            Debug.Log("Grounded");
            dirtParticles.Play();
            

        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            isGameOver = true;
            Debug.Log("GAME OVER!!!");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
<<<<<<< HEAD
=======

>>>>>>> main
            explosionParticles.Play();
            dirtParticles.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f );
        }
    }
}
