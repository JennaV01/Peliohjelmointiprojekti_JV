using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 100;
    //public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;
    public GameManagerScript gameManager;


    void Start()
    {   
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        //Physics.gravity *= gravityModifier;
    }

    void Update()
    {   //kun pelaaja painaa space-näppäintä pelihahmo hyppää
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {

            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
            ScoreManager.instance.AddPoint();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {   //jos pelihahmo juoksee maassa sora-animaatio pyörii
        if (collision.gameObject.CompareTag("Ground"))
        {   
            isOnGround = true;
            dirtParticle.Play();
            
            //jos pelihahmo törmää esteeseen pelihahmo kuolee, kaatumisen animaatio alkaa, sora-animaatio loppuu ja peli päättyy
        } else if (collision.gameObject.CompareTag("Obstacle"))
             
        {
            gameOver =true;
            Debug.Log("Game Over!");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            gameManager.gameOver();

        }
    }
}
