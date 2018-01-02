using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    void OnTriggerEnter2D()
    {
        GameController.instance.Died();
    }
   
}
