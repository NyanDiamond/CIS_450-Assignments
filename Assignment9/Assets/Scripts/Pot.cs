using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pot : MonoBehaviour
{

    State state;
    State[] states;
    [SerializeField] Sprite[] images;
    SpriteRenderer csr;
    float timer = 3f;
    ScoreManager sm;
    // Start is called before the first frame update
    void Start()
    {
        states = new State[]{new Empty(this), new Growing(this), new Grown(this), new Overgrown(this)};
        csr = transform.GetChild(0).GetComponent<SpriteRenderer>();
        UpdateState(0);
        sm = FindObjectOfType<ScoreManager>();
        StartCoroutine(Tick());
    }

    private void OnMouseDown()
    {
        state.OnClick();
    }

    private IEnumerator Tick()
    {
        while(true)
        {
            yield return new WaitForSeconds(timer);
            state.Tick();
        }
    }

    public void UpdateState(int temp)
    {
        state = states[temp];
        csr.sprite = images[temp];
    }

    public void AddScore()
    {
        sm.AddScore();
    }

    public void MinusScore()
    {
        sm.MinusScore();
    }

    


}
