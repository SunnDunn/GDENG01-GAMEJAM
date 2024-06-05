using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leviosa : MonoBehaviour
{
    public Collider radius;
    //public GameObject snowman;

    public List<Collider> objectsToLevitate = new List<Collider>();

    // Start is called before the first frame update
    void Start()
    {
        radius = GetComponent<Collider>();
        radius.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            for(int i = 0; i < objectsToLevitate.Count; i++)
            {
                GameObject levitating = objectsToLevitate[i].gameObject;

                levitating.GetComponent<Rigidbody>().useGravity = false;
                levitating.GetComponent<Rigidbody>().AddForce(-Physics.gravity);
            }

            /*other.attachedRigidbody.useGravity = false;
            other.attachedRigidbody.AddForce(-Physics.gravity);
            Debug.Log("Enter true if");*/
        }
        else
        {
            for (int i = 0; i < objectsToLevitate.Count; i++)
            {
                GameObject levitating = objectsToLevitate[i].gameObject;

                levitating.GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!objectsToLevitate.Contains(other))
        {
            objectsToLevitate.Add(other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (objectsToLevitate.Contains(other))
        {
            //remove it from the list
            objectsToLevitate.Remove(other);
            other.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
