using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : MonoBehaviour
{


    Vector3 thisTransformPos;

    private void OnTriggerEnter(Collider other) {
        thisTransformPos = this.gameObject.transform.position;

        this.gameObject.transform.position += new Vector3(0, 1000, 0); 

        this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
    }
}
