using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    
    public float speed = 2f;
    public flappy player;
    private bool isMovingUp = true;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        
        if (transform.position.x < -5f)
        {
            float yPosition = Random.Range(-3f, 3f);
            transform.position = new Vector3(4.5f, yPosition, 0f);
        }

        if (player.score >= 24) speed = 3.2f;

        if (player.score >= 50)
        {
            speed = 3.5f;
            if (isMovingUp)
            {
                transform.Translate(Vector3.up * .6f * Time.deltaTime);
                
                if (transform.position.y >= 2.52f) isMovingUp = false;
            }
            else
            {
                transform.Translate(Vector3.down * .6f * Time.deltaTime);
                
                if (transform.position.y <= -2.04f) isMovingUp = true;
            }
        }

    }

}
