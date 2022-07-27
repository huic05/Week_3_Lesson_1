using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private Animator animator;
    private Transform spriteTransfrom;
    private float xSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteTransfrom = transform.GetChild(0).GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Listen for the play to click to the button to play an animation clip
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("Cube");
        }

        //Gets the player input 
        xSpeed = Input.GetAxis("Horizontal");


        //Updates the Animator States based on player input 
        if(xSpeed != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        //Uses scale to flip the player left or right so we can use one animation for walking
        if(xSpeed < 0)
        {
            spriteTransfrom.localScale = new Vector3(1, 1, 1);
        }
        else if(xSpeed > 0)
        {
            spriteTransfrom.localScale = new Vector3(-1, 1, 1);
        }

        //Make the player move 
        transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);

    }
}
