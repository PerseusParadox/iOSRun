using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherCharacterScript : MonoBehaviour {
    public float rotationSpeed = 150.0f;
    public float runSpeed = 3.0f;
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        var x = Input.GetAxis ("Horizontal") * Time.deltaTime * rotationSpeed;
        var z = Input.GetAxis ("Vertical") * Time.deltaTime * runSpeed; //Input.GetAxis ("Vertical") means W and S 1,-1
                                                                        //Time.deltaTime means per second
        transform.Rotate (0 , x , 0);
        transform.Translate (0 , 0 , z);

        
    }
}
