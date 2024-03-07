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
            Tempgo.GetComponent<BallBehaviour>().TimeActive = 0;
            GameManager.instance.IncreaseScore();
            PoolScript.PSInstance.TurnOffObjects(Tempgo);
        }
    }
}
