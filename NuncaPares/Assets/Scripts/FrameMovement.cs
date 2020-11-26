using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameMovement : MonoBehaviour
{
    public float speed = 5.0f;
    float timeRemaining = 60.0f;
    float timeMove = 2.0f;
    bool moveUp = false;
    bool moveRight = false;
    bool timerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        moveUp = (Random.value > 0.5f);
        moveRight = (Random.value > 0.5f);

        if (timerIsRunning)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;

                while(timeMove > 0)
                {
                    if (moveUp)
                    {
                        transform.position = new Vector3(Mathf.Clamp(transform.position.x + (speed * Time.deltaTime), -6.0f, 6.0f), transform.position.y, transform.position.z);
                    }
                    else
                    {
                        transform.position = new Vector3(Mathf.Clamp(transform.position.x - (speed * Time.deltaTime), -6.0f, 6.0f), transform.position.y, transform.position.z);
                    }

                    if (moveRight)
                    {
                        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y + (speed * Time.deltaTime), -3.8f, 3.8f), transform.position.z);
                    }
                    else
                    {
                        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y - (speed * Time.deltaTime), -3.8f, 3.8f), transform.position.z);
                    }

                    timeMove -= Time.deltaTime;
                }

                timeMove = 2.0f;

                //transform.position = new Vector3(Mathf.Clamp(Input.GetAxis("Horizontal"), -8.0f, 8.0f), Mathf.Clamp(Input.GetAxis("Vertical"), -4.8f, 4.8f), transform.position.z);
            } else
            {
                Debug.Log("Time out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }




        } 
    }
}
