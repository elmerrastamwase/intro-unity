using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour
{

    public bool ifbool;
    public int value;

    // == lika
    // != inte lika
    // < mindre
    // > större 
    // <= lika/mindre
    // >= lika/större
    // && och
    // || eller

    public float uservalue;

    void uppgift1()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            uservalue /= 2;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            uservalue += 2;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(uservalue);
        }

    }

    float poäng = 10;

    void uppgift2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            poäng += (Random.Range(0, 7) - Random.Range(0, 7));
            Debug.Log(poäng);
        }
        if (poäng >= 20)
        {
            print("you win");
        }
        if (poäng <= 0)
        {
            print("you lose");
        }
        if (poäng <= 0 || poäng >= 20)
        {
            poäng = 10;
        }
    }

    int dragonhp;
    int playerhp = 100;
    int dragonHitChance;
    bool isAlive = false;
    int playerCrit;
    int superDragonChance;

    int oldValue = 50;
    int newvalue = 50;
    int score;
    int highscore;

    void uppgift3()
    {

        if (isAlive == false)
        {
            dragonhp = Random.Range(100, 151);
            superDragonChance = Random.Range(0, 11);
            if (superDragonChance >= 10)
            {
                print("you encountered a superdragon");
                dragonhp *= 2;
            }
            playerhp = 100;
            isAlive = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerCrit = Random.Range(0, 21);
            if (playerCrit >= 1)
            {
                dragonhp = 0;
                print("CRITICAL HIT!");
            }

            dragonhp -= Random.Range(Random.Range(5, 16), Random.Range(15, 31));

            dragonHitChance = Random.Range(0, 2);
            if (dragonHitChance >= 1)
            {
                playerhp -= Random.Range(10, 21);
            }
            print("player has " + playerhp + "hp" + "| Dragon has " + dragonhp + "hp");
        }
        if (dragonhp <= 0)
        {
            print("player wins");
            isAlive = false;
        }

        if (playerhp <= 0)
        {
            print("dragon wins");
            isAlive = false;
        }

    }

    void uppgift5()
    {


        if (Input.GetKeyDown(KeyCode.Y))
        {
            newvalue = Random.Range(0, 101);

            print("you guessed higher");
            if (oldValue < newvalue)
            {
                print("you where right");
                score += 1;
            }

            else if (oldValue == newvalue)
            {
                print("same dice");
                score += 0;
            }

            else
            {
                print("your score " + score);
                score = -1;
            }

            print("dice is " + newvalue);

        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            newvalue = Random.Range(0, 101);

            print("you guessed lower");
            if (oldValue > newvalue)
            {
                print("you where right");
                score += 1;
            }

            else if (oldValue == newvalue)
            {
                print("same dice");
                score += 0;
            }

            else
            {
                print("your score " + score);
                score = -1;
            }

            print("dice is " + newvalue);
        }

        if (score > highscore)
        {
            highscore = score;
            print ("new highscore " + highscore);
        }
    
        oldValue = newvalue;

        if (score == -1)
        {
            print("you lose");
            newvalue = 50;
            oldValue = 50;         
            print("your highscore is " + highscore);
            score = 0;
        }


    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        uppgift1();
        uppgift2();
        uppgift3();
        uppgift5();

    }
}
