using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleController : MonoBehaviour
{

    public Animator animator;

    float time = 0f;
    public float waitTime = 1f;
    float deltax = 15.75f;
    float destroyTime = 2.25f;
    public float speed = 7f;
    

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        destroyTime = deltax / speed;
        //animator = GetComponent<Animator>();
        animator.SetBool("IsWalking", false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;

        if(time > destroyTime){
            Destroy(gameObject);
        }
        else if(time > waitTime){
            animator.SetBool("IsWalking", true);
            this.gameObject.transform.position += this.gameObject.transform.forward * speed * Time.deltaTime;
        }
    }
}
