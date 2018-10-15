using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickColorChange : MonoBehaviour {

    public Joystick joystick;
    // Update is called once per frame
    void Update () {
        var x = joystick.Horizontal;
        var y = joystick.Vertical;
        var changeRate = x * y;
        //joystick.Image.color = new Vector4 (224 , 224 , 224 , 224);
        Debug.Log (changeRate);
        
    }
}
