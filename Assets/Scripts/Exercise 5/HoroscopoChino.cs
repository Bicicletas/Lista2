using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class HoroscopoChino : MonoBehaviour
{
    private int year;

    private int solution;

    public GameObject[] horoscope;
    public string[] horoscopeName;

    public TextMeshProUGUI horoscopeText;

    public void FindHoroscope(string s)
    {
        if(s != null)
        {
            year = Convert.ToInt32(s);
            solution = year % 12;
            horoscope[solution].SetActive(true);
            horoscopeText.text = horoscopeName[solution];
        }
    }

    public void Reset()
    {
        foreach(GameObject g in horoscope)
        {
            g.SetActive(false);
        }
        horoscopeText.text = "Chinese Horoscope";
    }
}
