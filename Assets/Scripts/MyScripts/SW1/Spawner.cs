using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject templateObject;
    [SerializeField] private bool run = false;

    private GameObject activeGameObject = null;

    private float tick = 0.0f;
    private float tickInterval = 1.0f;

    private Transform newTransform = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(run)
        {
            this.tick += Time.deltaTime;
            if(this.tick > this.tickInterval)
            {
                float x, y, z;
                Vector3 position;
                x = Random.Range(-13, -17);
                y = 1.358395f;
                z = Random.Range(11, 17);
                position = new Vector3(x, y, z);

                transform.position = position;

                this.tick = 0.0f;
            }
        }
    }
}
