using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCharScript : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //warming up
        if (Input.GetKey("q"))
        {
            animator.SetBool("pressing Q", true);
        }
        if (!Input.GetKey("q"))
        {
            animator.SetBool("pressing Q", false);
        }

        // Simple movement
         if (Input.GetKey("w"))
        {
            animator.SetBool("pressing W", true);
        }
        if (!Input.GetKey("w"))
        {
            animator.SetBool("pressing W", false);
        }
        
        // Advanced movement
         if (Input.GetKey("e"))
        {
            animator.SetBool("pressing E", true);
        }
        if (!Input.GetKey("e"))
        {
            animator.SetBool("pressing E", false);
        }
        
        // Final movement
         if (Input.GetKey("r"))
        {
            animator.SetBool("pressing R", true);
        }
        if (!Input.GetKey("r"))
        {
            animator.SetBool("pressing R", false);
        }
    }
}
