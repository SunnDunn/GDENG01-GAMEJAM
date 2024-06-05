using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDClear : MonoBehaviour
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
        EventBroadcaster.Instance.PostEvent(EventNames.TestEvents.ON_CLEAR_CLICKED);
    }
}
