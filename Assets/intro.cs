using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{
    /* public = syns i unity
     * 
     * int = heltal
     *  
     * hejsan = namnet
     * 
     * float = decimaltal med 7 precision
     * 
     * double = decimaltal med 15 precision
     * 
     * string = text
     * 
     * bool = true/false
     * 
     * char = ett tecken
     * 
     * inga variabler i en kod = hard code
     */
    public int hejsan;

    public float george;

    public double bush;

    public string minecraft;

    public bool jhon;

    public char dennis;

    // Use this for initialization
    void Start()
    {
        // PrintText();
        // PrintText();
        Debug.Log("hej" + "då!" + jhon + " " + minecraft);
        Debug.Log(string.Format("Hej då {0} {1}", jhon, minecraft));

    }

    void PrintText()
    {

        Debug.Log(9 / 2f);
        Debug.Log(9 / george);
        Debug.LogError(
            Mathf.Sqrt(548743) +
            Mathf.Sqrt(548743));
        Calculate();
    }

    void Calculate()
    {
        Debug.Log(minecraft);
        Debug.Log(hejsan + george);

    }

    // Update is called once per frame
    void Update()
    {


    }
}
