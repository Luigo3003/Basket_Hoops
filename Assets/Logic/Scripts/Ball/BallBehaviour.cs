using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject BallGO;
    private float TimeActive = 0;
    public float TimeToDespawn = 0;

    private void Start()
    {
        
    }

    private void Update() {
        TimeActive += Time.deltaTime;

        if (TimeActive > TimeToDespawn)
        {
            //PoolScript.PSInstance.TurnOffObjects(BallGO);
        }
    }
}
