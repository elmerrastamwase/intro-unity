using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quickmafs : MonoBehaviour
{
    //variabler för uppgifter
    public double nummer;
    public string sentence1, sentence2, sentence3;
    public double trianglebase;
    public double angle;
    public double bitar;
    public string playerName;
    public float radius;
    public int deamonHp;
    public int nrOfDeamons;
    public int maxPlayerDmg;
    public int minPlayerDmg;
    public int count;
    public float countMulti;
    public int maxPlayerHp;
    public float playerResist;
    public int enemyDmg;


    //uppgifter
    void uppgift1()
    {
        Debug.Log("(963 * 421) - (175463 / 87) =" + ((963f * 421f) - (175463f / 87f)));
    }

    void uppgift2()
    {
        Debug.Log(string.Format("hello {0}", sentence1));
        Debug.Log("i heard you like" + " " + sentence2);
        Debug.Log("i myself prefer" + " " + sentence3);
    }

    void uppgift3()
    {
        Debug.Log(Mathf.Pow(100, 2));
        Debug.Log(Mathf.Sqrt(100));
    }

    void uppgift4()
    {
        Debug.Log((8 * trianglebase) / 2 + " m^2");
    }

    void uppgift5()
    {
        Debug.Log(360 / angle);
        Debug.Log(360 / bitar);
    }

    void uppgift6()
    {
        Debug.Log("the mythcal" + " " + playerName + " " + "yeeter of all");
    }

    void uppgift7()
    {
        Debug.Log((4 * Mathf.PI * (Mathf.Pow(radius, 3)) / 3) * 2978); 
    }

    void uppgift8()
    {
        Debug.Log((deamonHp * nrOfDeamons) / Random.Range(minPlayerDmg, maxPlayerDmg));
    }

    void uppgift9()
    {
        count = count * 2;
        Debug.Log(count);

    }

    void uppgift10()
    {
        Debug.Log((countMulti * 3) / 2);

    }

    void uppgift11()
    {
        Debug.Log(maxPlayerHp - (enemyDmg * playerResist));

    }

    // Use this for initialization
    void Start()
    {
        uppgift1();
        uppgift2();
        uppgift3();
        uppgift4();
        uppgift5();
        uppgift6();
        uppgift7();
        uppgift8();
        uppgift10();
        uppgift11();
    }

    // Update is called once per frame
    void Update()
    {
        uppgift9();




    }
}
