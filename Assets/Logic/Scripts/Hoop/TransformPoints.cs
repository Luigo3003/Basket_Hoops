using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPoints : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Colision" + collision.name);
        collision.GetComponent<HoopMovement>().MoveHoop();
    }

}
