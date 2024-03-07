using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopMovement : MonoBehaviour
{
    public Transform[] TransPositions;
    public float speed = 0.5f;
    int NextTransform = 0;
    public bool Forward = true;

    void Update()
    {
        if (transform.position == TransPositions[0].position)
        {
            Forward = true;
            NextTransform++;
            if (transform.position == TransPositions[NextTransform].position && Forward == true)
            {
                transform.position = Vector2.MoveTowards(transform.position, TransPositions[1].position, speed * Time.deltaTime);
            }
        }
        else if (NextTransform == TransPositions.Length - 1)
        {
            Forward = false;
        }


        else if (transform.position == TransPositions[NextTransform].position && Forward == false)
        {
            NextTransform--;
            Vector2.MoveTowards(transform.position, TransPositions[NextTransform].position, speed * Time.deltaTime);
        }
    }

    public void MoveHoop()
    {




    }
}
