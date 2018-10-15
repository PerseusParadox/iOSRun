using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerate : MonoBehaviour {
    public GameObject character;
    public GameObject ground;
    // Update is called once per frame
    void Update () {
        var generatePosition = character.transform.position.x + Random.Range (20f , 40f);
        Instantiate (ground , new Vector3 (generatePosition , Random.Range (-20 , 20) , 0) , Quaternion.identity);
    }
}
