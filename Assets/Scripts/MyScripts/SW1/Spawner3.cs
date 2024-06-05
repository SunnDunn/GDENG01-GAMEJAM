using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour
{

    [SerializeField] private GameObject bigCube;
    [SerializeField] private GameObject spawnCopy;
    [SerializeField] private List<GameObject> spawns;

    // Start is called before the first frame update
    void Start()
    {
        this.spawnCopy.SetActive(false);
        this.StartCoroutine(this.destroyAfter(2.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private GameObject spawnDefault(GameObject spawnCopy, Transform transform, Vector3 position)
    {
        GameObject obj = GameObject.Instantiate(this.spawnCopy);
        obj.SetActive(true);
        return obj;
    }

    private IEnumerator destroyAfter(float secs)
    {
        yield return new WaitForSeconds(secs);

        this.bigCube.SetActive(false);

        for(int i = 0; i < 500; i++)
        {
            Vector3 localPos = this.bigCube.transform.localPosition;

            localPos.x += Random.Range(-1.0f, 1.0f);
            localPos.y += Random.Range(-1.0f, 1.0f);
            localPos.z += Random.Range(-1.0f, 1.0f);

            GameObject obj = this.spawnDefault(this.spawnCopy, this.transform.parent, localPos);
            this.spawns.Add(obj);
        }

        yield return new WaitForSeconds(5.0f);

        for(int i = 0; i < this.spawns.Count; i++)
        {
            GameObject.Destroy(this.spawns[i]);
        }

        this.spawns.Clear();
        this.bigCube.SetActive(true);
        this.StartCoroutine(this.destroyAfter(secs));
    }
}
