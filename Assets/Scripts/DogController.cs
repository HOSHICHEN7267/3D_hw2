using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
    public Animator dogAnime;

    public float speed = 0.8f;
    bool isWalking = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isWalking = false;
        
        if (Input.GetKey(KeyCode.RightArrow)) {
            isWalking = true;
            Quaternion newRotation = Quaternion.Euler(0, 90f, 0);
            this.gameObject.transform.rotation = newRotation;
            this.gameObject.transform.position += this.gameObject.transform.forward * speed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            isWalking = true;
            Quaternion newRotation = Quaternion.Euler(0, -90f, 0);
            this.gameObject.transform.rotation = newRotation;
            this.gameObject.transform.position += this.gameObject.transform.forward * speed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            isWalking = true;
            Quaternion newRotation = Quaternion.Euler(0, 0, 0);
            this.gameObject.transform.rotation = newRotation;
            this.gameObject.transform.position += this.gameObject.transform.forward * speed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            isWalking = true;
            Quaternion newRotation = Quaternion.Euler(0, 180f, 0);
            this.gameObject.transform.rotation = newRotation;
            this.gameObject.transform.position += this.gameObject.transform.forward * speed * Time.fixedDeltaTime;
        }

        if(isWalking){
            dogAnime.SetInteger("Status", 1);
        }
        else{
            dogAnime.SetInteger("Status", 0);
        }
    }
}
