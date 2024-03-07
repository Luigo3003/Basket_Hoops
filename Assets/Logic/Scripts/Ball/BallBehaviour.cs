using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float TimeActive = 0;
    public float TimeToDespawn = 0;



    private void Update() {
        TimeActive += Time.deltaTime;

        if (TimeActive > TimeToDespawn)
        {
            PoolScript.PSInstance.TurnOffObjects(gameObject);
            TimeActive = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Boundary"))
        {
            print("Collision Enter");
            GameManager.instance.ResetScore();
        }
        
    }


}
