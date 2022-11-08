using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoundManager : MonoBehaviour
{
    public GameObject enemy;

    public new Camera camera;

    private float XBound = 8f;
    private float ZBound = 6f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Enemy"))
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

    private void NextRound()
    {
        float XRandomIndex = Random.Range(-XBound, XBound);
        float ZRandomIndex = Random.Range(-ZBound, ZBound);

        Instantiate(enemy, new Vector3(XRandomIndex, 0.5f, ZRandomIndex), transform.rotation);
    }
}
