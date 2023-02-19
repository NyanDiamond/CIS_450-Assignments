using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected float valueWeight;
    [SerializeField] protected ItemDropper dropper;
    [SerializeField] protected int rolls;
    [SerializeField] protected float force;

    public void RandomItem()
    {
        GameObject itemToSpawn = dropper.RandomItem(Random.Range(0 + valueWeight/100, 1));
        GameObject spawnedItem = Instantiate(itemToSpawn, transform.position, Quaternion.identity);
        spawnedItem.GetComponent<Rigidbody2D>().AddForce(force * (Vector2.up + new Vector2
            (Random.Range(-1f, 1f), 0f)).normalized, ForceMode2D.Impulse);
    }

    public void Death()
    {
        for (int i = 0; i<rolls; i++)
        {
            RandomItem();
        }
    }
}
