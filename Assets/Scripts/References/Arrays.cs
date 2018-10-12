using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {
    string[] strings = new string[3]; //method one of making an array.. type[] name = new type [length];
    public int[] myFavInts = { 69 , 70 , 71 , 72 }; //method two assign values before start
    /*
     Useful commands :
     GameObject.FindGameObjectsWithTag ("TagName"); //finds gameobjects with tag

     for ( int i = 0 ; i < Array.Length ; i++ ) { //loops through index of arrays

        }

        foreach ( string item in strings ) { //good way to loop through an Array
            Debug.Log (item);
        }

         */
    void Start () {

        strings[0] = "First string"; //assign values in start
        strings[1] = "Second string";
        strings[2] = "Third string";

        
    }


}
