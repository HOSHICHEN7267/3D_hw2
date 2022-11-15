using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            Quaternion newRotation = Quaternion.Euler(0, 90f, 0);
            this.gameObject.transform.rotation = newRotation;
            this.gameObject.transform.position += this.gameObject.transform.forward * speed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            Quaternion newRotation = Quaternion.Euler(0, -90f, 0);
            this.gameObject.transform.rotation = newRotation;
            this.gameObject.transform.position += this.gameObject.transform.forward * speed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            Quaternion newRotation = Quaternion.Euler(0, 0, 0);
            this.gameObject.transform.rotation = newRotation;
            this.gameObject.transform.position += this.gameObject.transform.forward * speed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            Quaternion newRotation = Quaternion.Euler(0, 180f, 0);
            this.gameObject.transform.rotation = newRotation;
            this.gameObject.transform.position += this.gameObject.transform.forward * speed * Time.fixedDeltaTime;
        }
    }
}
