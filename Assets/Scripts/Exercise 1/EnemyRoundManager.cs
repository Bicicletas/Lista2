using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoundManager : MonoBehaviour
{
    public GameObject enemy;

    public new Camera camera;

    private float XBound = 8f;
    private float ZBound = 6f;

    public int enemyCounter = 0;
    public int roundCounter = 2;

    private void Start()
    {
        NextRound();
        roundCounter = 1;
    }

    private void Update()
    {
        // Every time you hit a certaing gameObject using a raycast it destroys and removes 1 to the enemyCounter
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Enemy"))
                {
                    Destroy(hit.collider.gameObject);
                    enemyCounter--;
                }
            }
        }
        // If the enemyCounter is 0 starts a new round and instantiates an amount of enemies determinates by the number of the round
        if(enemyCounter == 0)
        {
            roundCounter++;

            for (int i = 1; roundCounter >= i; i++)
            {
                NextRound();
            }
        }
    }

    // Function that determinates a random position of X nad Z in a predifined bounds and
    // instantiates a gameObjet inside the bounds and adds 1 to the enemyCounter every time
    private void NextRound()
    {
        float XRandomIndex = Random.Range(-XBound, XBound);
        float ZRandomIndex = Random.Range(-ZBound, ZBound);

        Instantiate(enemy, new Vector3(XRandomIndex, 0.5f, ZRandomIndex), transform.rotation);
        enemyCounter++;
    }
}
