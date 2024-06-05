using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Magic : MonoBehaviour
{
    private bool LEVIOSA = false;
    private Collider col;

    // Start is called before the first frame update
    void Start()
    {
        this.col = GetComponent<Collider>();
        //this.col.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.LEVIOSA);
        if (this.LEVIOSA == true && Input.GetKey(KeyCode.E))
        {
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().AddForce(-Physics.gravity);
        }
        else
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Plane")
        {
            this.LEVIOSA = true;
        }

        /*if(other.name == "Plane")
        {
            other.attachedRigidbody.detectCollisions = true;
        }*/

        /*this.LEVIOSA = true;*/
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Plane")
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            this.LEVIOSA = false;
        }

        /*gameObject.GetComponent<Rigidbody>().useGravity = true;
        this.LEVIOSA = false;*/
    }
}
