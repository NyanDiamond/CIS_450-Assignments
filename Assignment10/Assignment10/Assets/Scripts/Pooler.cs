using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public List<GameObject> pieces;
    }

    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> poolDictionary;

    public static Pooler instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach(Pool pool in pools)
        {
            Requeue(pool.tag);
        }
    }

    private void Requeue(string tag)
    {
        foreach(Pool pool in pools)
        {
            if(tag == pool.tag)
            {
                Queue<GameObject> objectPool = new Queue<GameObject>();
                List<GameObject> temp = new(pool.pieces);
                while (temp.Count > 0)
                {
                    int index = Random.Range(0, temp.Count);
                    objectPool.Enqueue(temp[index]);
                    temp.RemoveAt(index);
                }
                if (!poolDictionary.ContainsKey(tag))
                    poolDictionary.Add(pool.tag, objectPool);
                else
                    poolDictionary[tag] = objectPool;
            }
        }
    }

    public void SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool does not contain tag " + tag);
            return;
        }

        GameObject objectToSpawn = poolDictionary[tag].Dequeue();
        Instantiate(objectToSpawn, position + Vector3.forward * 1000, rotation);
        if(poolDictionary[tag].Count==0)
        {
            Requeue(tag);
        }
    }
}
