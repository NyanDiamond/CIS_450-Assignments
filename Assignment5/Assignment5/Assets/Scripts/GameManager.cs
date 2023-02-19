using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text totalValue;
    private int currentMoney = 0;
    [SerializeField] Enemy simulatedEnemy;
    // Start is called before the first frame update
    void Start()
    {
        totalValue.text = "Current Money: " + currentMoney;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Add(int value)
    {
        currentMoney += value;
        totalValue.text = "Current Money: " + currentMoney;
    }

    public void SimulateDeath()
    {
        simulatedEnemy.Death();
    }
}
