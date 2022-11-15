using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleController : MonoBehaviour
{

    public Animator animator;

    float time = 0f;
    public float waitTime = 1f;
    public float speed = 0.2f;
    public float destroyTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        //animator = GetComponent<Animator>();
        animator.SetBool("IsWalking", false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time > destroyTime){
            Destroy(gameObject);
        }
        else if(time > waitTime){
            animator.SetBool("IsWalking", true);
            this.gameObject.transform.position += this.gameObject.transform.forward * speed;
        }
    }
}
