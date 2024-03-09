using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    { 
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical"); 
        
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 scale = transform.localScale;
            scale.x = 1f * Mathf.Abs(scale.x);
            animator.SetBool("IsRunning", true);
            playerMovement(horizontal);
        }

        if(Input.GetKey(KeyCode.A))
        {
            Vector3 scale = transform.localScale;
            scale.x = -1f * Mathf.Abs(scale.x);
            animator.SetBool("IsRunning", true);
            playerMovement(horizontal);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
            animator.SetBool("IsJumping", false);
        }
    }

    void playerMovement(float horizontal)
    {
        Vector3 position = transform.position;
        position.x = position.x + horizontal * speed * Time.deltaTime;
        transform.position = position;
    }

    void Jumping()
    {

    }
}
