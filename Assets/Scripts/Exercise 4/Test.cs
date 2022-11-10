using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
    public TextMeshProUGUI option1;

    public TextMeshProUGUI option2;

    private int randomPick = 0;

    private int options = 10;

    private int turn = 1;

    private int right;
    private int wrong;

    public GameObject endPanel;

    public TextMeshProUGUI rightText;
    public TextMeshProUGUI wrongText;

    private int[] playerPick = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

    private void Update()
    {
        // If the turn is 10 or lower the machine picks a random number bettween 1 and 2
        if(turn < 11)
        {
            for (int i = 0; turn > i; i++)
            {
                randomPick = Random.Range(0, 2);
            }
            // Explenation in the function itself
            Options(1, "1", "2");
            Options(2, "a", "b");
            Options(3, "even", "odd");
            Options(4, "black", "white");
            Options(5, "in", "out");
            Options(6, "up", "down");
            Options(7, "on", "off");
            Options(8, "yes", "no");
            Options(9, "sea", "swiming pool");
            Options(10, "heaven", "hell");
        }
        else
        {
            //at the end of the 10th round a panel pops up and it show the right and wrong answers
            rightText.text = $"{right}";
            wrongText.text = $"{wrong}";
            endPanel.SetActive(true);
        }
    }

    // Function of a button that picks the number 1 and compares it to the choice of the machine and goes to the next round
    public void Pick1()
    {
        if (turn < 11)
        {
            playerPick[turn] = 1;
            turn++;
            if (playerPick[turn] == randomPick)
            {
                right++;
            }
            else
            {
                wrong++;
            }
        }
    }

    // Function of a button that picks the number 2 and compares it to the choice of the machine and goes to the next round
    public void Pick2()
    {
        if (turn < 11)
        {
            playerPick[turn] = 1;
            turn++;
            if (playerPick[turn] == randomPick)
            {
                right++;
            }
            else
            {
                wrong++;
            }
        }
    }

    //Shows the 2 chices using a text that changes depending on the round
    private void Options(int i, string s1, string s2)
    {
        if (turn == i)
        {
            option1.text = s1;
            option2.text = s2;
        }
    }
}
