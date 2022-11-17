using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {	    if(Input.GetKey(KeyCode.W)) {
            	transform.Translate(Vector3.forward * Time.deltaTime * 50);
            }
            if(Input.GetKey(KeyCode.S)) {
	                	transform.Translate(Vector3.back * Time.deltaTime * 50);
            }
            if(Input.GetKey(KeyCode.D)) {
	    	                	transform.Rotate(Vector3.up * Time.deltaTime * 50);
            }
            if(Input.GetKey(KeyCode.A)) {
	    	                	transform.Rotate(Vector3.down * Time.deltaTime * 50);
            }
       
    }
}
