using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text toggle;
    Factory factory;
    [SerializeField] string[] viableBuffTypes;
    Button[] buttons;
    // Start is called before the first frame update
    void Start()
    {
        toggle.text = "Switch to Debuffs";
        factory = new BuffFactory();
        buttons = FindObjectsOfType<Button>();
    }

    public void SpawnConsumable(string temp)
    {
        if (viableBuffTypes.Contains(temp))
            factory.SpawnConsumable(temp);
        else
            Debug.Log("No buff of that type avalible");
    }

    public void ToggleType()
    {
        Color temp = Color.white;
        if (factory is BuffFactory)
        {
            toggle.text = "Switch to Buffs";
            factory = new DebuffFactory();
            temp = Color.red;
        }
        else
        {
            toggle.text = "Switch to Debuffs";
            factory = new BuffFactory();
            temp = Color.green;
        }
        foreach(Button button in buttons)
        {
            ColorBlock cb = new ColorBlock();
            cb.normalColor = temp;
            cb.pressedColor = temp;
            cb.highlightedColor = temp;
            cb.selectedColor = temp;
            cb.colorMultiplier = 1;
            button.colors = cb;
        }
    }
}
