using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopMovement : MonoBehaviour
{
    public Transform[] TargetTransforms;
    [SerializeField] private float speed = 10f;

    private void Start()
    {
        TargetTransforms = new Transform[0];
    }

    void Update()
    {
        
    }

    public void MoveHoop()
    {
        int NextTransform = 0;
        if (transform.position == TargetTransforms[0].position)
        {
           NextTransform = NextTransform + 1;
            transform.position = Vector2.MoveTowards(transform.position, TargetTransforms[NextTransform].position, speed * Time.deltaTime);
        }
        else if (NextTransform == TargetTransforms.Length - 1)
        {
            NextTransform = NextTransform - 1;
            transform.position = Vector2.MoveTowards(transform.position, TargetTransforms[NextTransform].position, speed * Time.deltaTime);
        }
        
    }
}
