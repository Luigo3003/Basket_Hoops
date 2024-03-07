using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopBehaviour : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject Tempgo = collision.gameObject;
        
        if (collision.CompareTag("Ball"))
        {
            print("Enter the trigger");
            GameManager.instance.IncreaseScore();
            PoolScript.PSInstance.TurnOffObjects(Tempgo);
        }
    }
}
