using UnityEngine;

public class TransitionAnimations : MonoBehaviour
{

    public Animator animator;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Jump", true);
            animator.Play(Animator.StringToHash("Jump"), 0, 0.25f);           // Jump
        }
        else
        {
            animator.SetBool("Jump", false);
        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Walk", true);
            animator.Play(Animator.StringToHash("Crouched Walking"), 0, 0.25f);           // Walk
        }
        else
        {
            animator.SetBool("Walk", false);
        }


        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.Play(Animator.StringToHash("Run"), 0, 0.25f);           // Run

        }

    }






}
