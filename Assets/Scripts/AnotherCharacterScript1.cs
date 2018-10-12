using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherCharacterScript1 : MonoBehaviour {
    public float rotationSpeed = 150.0f;
    public float runSpeed = 3.0f;
    public Animator animator;
    public Joystick joystick;
    public Rigidbody rb;
    public float jumpHeight = 5;
    public CapsuleCollider collider;
    public float fly = 0.5f;
    bool grounded;
    public float sensitivity = 0.2f;
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        //grounded = Physics.Raycast (rb.transform.position , Vector3.up , collider.radius * fly);
        if ( transform.position.y > -0.02 )
            grounded = false;
        else
            grounded = true;

        var x = Input.GetAxis ("Horizontal") * Time.deltaTime * rotationSpeed;
        var z = Input.GetAxis ("Vertical") * Time.deltaTime * runSpeed * -1; //Input.GetAxis ("Vertical") means W and S 1,-1
        var y = joystick.Horizontal * Time.deltaTime * rotationSpeed;
        var k = joystick.Vertical * Time.deltaTime * runSpeed * -1;                  //Time.deltaTime means per second
        transform.Rotate (0 , y , 0);
        transform.Translate (0 , 0 , k);
        Debug.DrawRay (transform.position , Vector3.forward , Color.blue);

        var anim = joystick.Vertical * 12;
        if ( grounded ) {
            animator.SetBool ("isInAir" , false);
        } else {
            animator.SetBool ("isInAir" , true);
        }

        if ( k != 0 || y != 0 ) {
            animator.SetFloat ("speed" , anim);


        } else {
            animator.SetFloat ("speed" , anim);
        }


    }
    public void Jump () {


        if ( grounded ) {

            rb.AddForce (Vector3.up * jumpHeight , ForceMode.Impulse);
        }

        /*private bool isGrounded () {

            return Physics.Raycast (transform.position , Vector3.up , fly);
           // return Physics.CheckCapsule (collider.bounds.center , new Vector3 (collider.bounds.center.x , collider.bounds.min.y - 0.1f , collider.bounds.center.z) , 0.18f);
            //return Physics.CheckCapsule (collider.bounds.center , new Vector3 (collider.bounds.center.x , collider.bounds.min.y , collider.bounds.center.z) , collider.height * fly);
        }*/









        /*if ( animator.GetBool ("isInAir") ) {
            animator.SetBool ("isInAir" , false);

        } else {
            animator.SetBool ("isInAir" , true);
            rb.AddForce (Vector3.up * jumpHeight , ForceMode.Impulse);
        }*/


        /*if ( animator.GetBool ("isInAir") == false ) { //enable jump
            animator.SetBool ("isInAir" , true);
            rb.AddForce (Vector3.up * jumpHeight , ForceMode.Impulse);
            // Physics.CheckCapsule (collider.bounds.center , new Vector3 (collider.bounds.x , collider.bounds.min.y , collider.bounds.z) , );
        }*/
    }
}
