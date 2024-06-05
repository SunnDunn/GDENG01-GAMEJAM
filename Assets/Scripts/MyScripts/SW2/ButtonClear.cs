using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClear : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectList;

    // Start is called before the first frame update
    void Start()
    {
        this.objectList = GetComponent<ButtonSpawn>().GetObjectList();

        EventBroadcaster.Instance.AddObserver(EventNames.TestEvents.ON_CLEAR_CLICKED, this.OnClearEvent);
    }

    void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.TestEvents.ON_CLEAR_CLICKED);
    }

    // Update is called once per frame
    void Update()
    {
        this.objectList = GetComponent<ButtonSpawn>().GetObjectList();
    }

    private void OnClearEvent()
    {
        for (int i = 0; i < this.objectList.Count; i++)
        {
            GameObject.Destroy(this.objectList[i]);
        }
    }
}
