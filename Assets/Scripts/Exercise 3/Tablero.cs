using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablero : MonoBehaviour
{
    public int movement = 120;

    public int borderY = 0;

    public int borderX = 0;

    private int maxBorder = 2;

    private void Update()
    {
        // When you click W (up), A (left), S (down), D (right) the player moves by a defined amount if the border is not higher than maxBorder
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (borderY < maxBorder)
            {
                gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + movement, 0);
                borderY++;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (borderX > -maxBorder)
            {
                gameObject.transform.position = new Vector3(transform.position.x - movement, transform.position.y, 0);
                borderX--;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (borderY > -maxBorder)
            {
                gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - movement, 0);
                borderY--;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (borderX < maxBorder)
            {
                gameObject.transform.position = new Vector3(transform.position.x + movement, transform.position.y, 0);
                borderX++;
            }
        }
    }
}
