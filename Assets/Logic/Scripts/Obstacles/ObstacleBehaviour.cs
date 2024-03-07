using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    public int obstacleLife = 0;

    public void takeDamage()
    {
        obstacleLife--;
        CheckLife();
    }

    private void CheckLife()
    {
        if (obstacleLife < 0)
        {
            gameObject.SetActive(false);
        }

    }
}
