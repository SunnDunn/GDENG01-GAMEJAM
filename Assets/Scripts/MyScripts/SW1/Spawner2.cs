using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{


    [SerializeField] private GameObject templateObject;
    [SerializeField] private GameObject templateObject2;
    [SerializeField] private bool run = false;

    [SerializeField] List<GameObject> objList;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(run)
        {
            this.spawnDefault();
            this.despawn(10.0f);
        }
    }

    private GameObject spawnDefault()
    {
        GameObject obj = null;

        int num = Random.Range(0, 3);
        
        if(num == 1)
        {
            obj = GameObject.Instantiate(this.templateObject);
        }
        
        obj.SetActive(true);
        this.objList.Add(obj);

        return obj;
    }

    private IEnumerator despawn(float secs)
    {
        yield return new WaitForSeconds(secs);

        for (int i = 0; i < this.objList.Count; i++)
        {
            GameObject.Destroy(this.objList[i]);
        }

        this.objList.Clear();
    }
}
