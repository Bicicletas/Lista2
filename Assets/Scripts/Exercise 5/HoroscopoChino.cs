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

    public TMP_InputField inputField;

    // Function of an input field that enters a string, converts it to an int and determinates the solution and find
    // the match determined by the order of an array showing, at the end, the correct chinese horoscope image and name
    public void FindHoroscope(string s)
    {
        if(s != "")
        {
            year = Convert.ToInt32(s);
            solution = year % 12;
            horoscope[solution].SetActive(true);
            horoscopeText.text = horoscopeName[solution];
        }
    }

    // Function of an input field that resets the images and the names every time the text value changes
    public void Reset()
    {
        foreach(GameObject g in horoscope)
        {
            g.SetActive(false);
        }
        horoscopeText.text = "Chinese Horoscope";
    }
}
