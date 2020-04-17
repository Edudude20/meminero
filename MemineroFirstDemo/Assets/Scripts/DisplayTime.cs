using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{

    public GameObject theDisplay;
    public float hour;
    public float minutes;
    public int Kuukausi;
    public int Paiva;
    public int Vuosi;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Paiva = System.DateTime.Now.Day;
        Kuukausi = System.DateTime.Now.Month;
        Vuosi = System.DateTime.Now.Year;
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        string minutee = "" + minutes;
        string hours = "" + hour;

        if (minutes < 10)
        {
            minutee = "0" + minutes;
        }

        if (hour < 10)
        {
            hours = "0" + hour;
        }

        theDisplay.GetComponent<Text>().text = "" + Paiva + "." + Kuukausi + "." + Vuosi + "  " + hours + ":" + minutee + "";

    }
}
