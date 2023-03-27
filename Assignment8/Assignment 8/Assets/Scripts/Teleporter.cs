using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : Runner
{
    [SerializeField] float pauseTimer;
    bool paused = false;

    protected override void Move()
    {
        if(!paused)
        {
            paused = true;
            transform.position = transform.position + transform.right * Random.Range(0, 5f);
            transform.position = new Vector2(Mathf.Clamp(transform.position.x, -8.5f, 8.5f), Mathf.Clamp(transform.position.y, -3.5f, 3.5f));
            StartCoroutine(Pause());
        }
    }
    IEnumerator Pause()
    {
        yield return new WaitForSeconds(pauseTimer);
        paused = false;
    }
}
