using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {

    public float runSpeed = 3.0f;
    public Animator animator;
    public Joystick joystick;
    public Rigidbody rb;
    public float jumpHeight = 5;
    public CapsuleCollider collider;
    public float fly = 0.5f;
    public bool grounded;
    bool groundedR;
    public float sensitivity = 0.2f;
    //Camera
    public Camera followerCamera;
    public float smoothCameraMovement = 0.1f;
    public Vector3 cameraOffset;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        Debug.DrawRay (transform.position , Vector3.down , Color.cyan);
        var y = joystick.Horizontal * Time.deltaTime * runSpeed;
        var k = joystick.Vertical * Time.deltaTime * runSpeed;




        var anim = Mathf.Abs (joystick.Horizontal * 12);


        //Movement
        if ( joystick.Horizontal > sensitivity || joystick.Horizontal < -sensitivity || joystick.Vertical > sensitivity || joystick.Vertical < -sensitivity ) {
            if ( ( joystick.Horizontal > sensitivity || joystick.Horizontal < -sensitivity ) && !grounded ) {
                animator.SetFloat ("speed" , anim);
                rb.velocity = new Vector3 (y , k , 0f);
            } else {
                rb.velocity = new Vector3 (y , k , 0f);
                animator.SetFloat ("speed" , anim);
            }

        } else {
            animator.SetFloat ("speed" , 0);
        }







        //Rotation
        if ( y > 0 )
            transform.rotation = Quaternion.AngleAxis (270 , Vector3.up);
        else if ( y < 0 )
            transform.rotation = Quaternion.AngleAxis (90 , Vector3.up);
        else transform.rotation = transform.rotation;


    }
    private void FixedUpdate () {
        //grounded = Physics.Raycast (transform.position , Vector3.down , out hit , 0.1f);
        Ray ray = new Ray (transform.position , Vector3.down);
        grounded = Physics.Raycast (ray);
        groundedR = !grounded;
        if ( grounded )
            animator.SetBool ("isInAir" , true);
        else
            animator.SetBool ("isInAir" , false);



    }

    private void LateUpdate () {
        //Camera Mechanics
        Vector3 targetPosition = transform.position + cameraOffset;
        followerCamera.transform.position = Vector3.Lerp (followerCamera.transform.position , targetPosition , smoothCameraMovement);

    }




    public void Jump () {


        if ( groundedR ) {
            rb.AddForce (Vector3.up * jumpHeight , ForceMode.Impulse);
        }

    }
}
