using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour {
    string[] strings = new string[3]; //method one of making an array.. type[] name = new type [length];
    public int[] myFavInts = { 69 , 70 , 71 , 72 }; //method two assign values before start

    void Start () {

        strings[0] = "First string"; //assign values in start
        strings[1] = "Second string";
        strings[2] = "Third string";
        for ( int i = 0 ; i < myFavInts.Length ; i++ ) {
            print (myFavInts[i]);
        }

        
        do {
            print ("There goes the do loop you piece of shit!");
        } while ( false );
    }


}
