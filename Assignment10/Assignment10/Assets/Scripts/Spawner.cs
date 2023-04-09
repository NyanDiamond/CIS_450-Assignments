using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    Pooler pooler;
    // Start is called before the first frame update
    void Start()
    {
        pooler = Pooler.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            pooler.SpawnFromPool("tetra", Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.Euler(0, 0, 90 * (int)Random.Range(0, 4)));
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            pooler.SpawnFromPool("penta", Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.Euler(0, 0, 90 * (int)Random.Range(0, 4)));
        }
    }
}
