using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulator : MonoBehaviour
{
    List<Creature> creatures;
    List<Enemy> enemies;
    List<CanFly> fliers;
    // Start is called before the first frame update
    void Start()
    {
        Parrot testParrot = new Parrot();
        Goblin testGoblin = new Goblin();
        Debug.Log("Testing test goblin");
        testGoblin.ChangeHP(-15);
        testGoblin.Attack();
        Debug.Log("Testing test parrot");
        testParrot.Fly();
        testParrot.SetMaxHeight(1);
        testParrot.Fly();
        testParrot.SetMaxHeight(0);
        testParrot.Fly();
        testParrot.ChangeHP(-2);

        Parrot parrot1 = new Parrot();
        Parrot parrot2 = new Parrot();
        Goblin goblin1 = new Goblin();
        Goblin goblin2 = new Goblin();
        Dragon dragon = new Dragon();

        creatures = new List<Creature> { parrot1, parrot2, goblin1, goblin2, dragon };
        enemies = new List<Enemy> { goblin1, goblin2, dragon };
        fliers = new List<CanFly> { parrot1, parrot2, dragon };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Creature temp in creatures)
            {
                temp.ChangeHP(Random.Range(-6, 2));
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (Enemy temp in enemies)
            {
                temp.Attack();
            }
            foreach(CanFly temp in fliers)
            {
                temp.Fly();
            }
        }
    }
}
