using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassScript : MonoBehaviour
{
    private Animator an;
    private float xSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        an = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        xSpeed = Input.GetAxis("Horizontal");
        if (xSpeed != 0)
        {
            an.SetBool("isWalking", true);

        }
        else
        {
            an.SetBool("isWalking", true);
        }
        if (xSpeed < 0)
        {
            
        }
        if (xSpeed > 0)
        {

        }
        transform.position = new Vector3(xSpeed * Time.deltaTime, 0, 0);
    }
}
