using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCubes : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {

        if(other.tag == "Blue"){
            Destroy(other);
        }

        if(other.tag == "Red"){
            Destroy(other);
        }
    }
}
