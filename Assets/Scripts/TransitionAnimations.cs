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

            animator.Play(Animator.StringToHash("Jump"), 0, 0.25f);           // Jump

        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Walk", True);
            Debug.Log("walk");
            animator.Play(Animator.StringToHash("Crouched Walking"), 0, 0.25f);           // Walk

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {

            Debug.Log("run");
            animator.Play(Animator.StringToHash("Run"), 0, 0.25f);           // Run

        }

    }






}
