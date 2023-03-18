using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    public float speed;
    public Color[] colors;
    public int colorIdx = 0;
    SpriteRenderer sr;


    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        UpdateColor();
    }
    public void Move(Vector2 dir)
    {
        transform.Translate(dir * speed);
    }

    public void ColorUp()
    {
        colorIdx++;
        if (colorIdx >= colors.Length)
            colorIdx = 0;
        UpdateColor();
    }

    public void ColorDown()
    {
        colorIdx--;
        if (colorIdx < 0)
            colorIdx = colors.Length - 1;
        UpdateColor();
    }

    private void UpdateColor()
    {
        sr.color = colors[colorIdx];
    }
}
