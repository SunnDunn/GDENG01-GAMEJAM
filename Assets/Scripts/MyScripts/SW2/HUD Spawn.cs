using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClicked()
    {
        EventBroadcaster.Instance.PostEvent(EventNames.TestEvents.ON_SPAWN_CLICKED);
    }
}
