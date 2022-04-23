using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shakey : MonoBehaviour
{
    
    [SerializeField]
    private float speed;

    [SerializeField]
    private float startTime = 3.0f;

    [SerializeField]
    private float endTime = 7.0f;

    [SerializeField]
    private List<GameObject> positionList;

    private Vector2 target;
    private float countdown;

    private Vector2 positionCheck;
    private Vector2 currentPosition;

    [SerializeField] private bool allowMovement;

    private void Start()
    {
        allowMovement = true;

        currentPosition = transform.position;
        SetRandomPosition();
    }

    private void Update()
    {
        if (allowMovement)
        {
            if (countdown < 0f)
            {
                SetRandomWaitTime();
                SetRandomPosition();
            }
            else
            {
                countdown -= Time.deltaTime;
            }

            Debug.Log(countdown);

            transform.position = Vector2.MoveTowards(transform.position,
                target, speed * Time.deltaTime);
        }
    }

    private void SetRandomWaitTime()
    {
        countdown = Random.Range(startTime, endTime);
    }


    private void SetRandomPosition()
    {
        positionCheck = positionList[Random.Range(0, positionList.Count)].transform.position;

        while (positionCheck == currentPosition)
        {
            positionCheck = positionList[Random.Range(0, positionList.Count)].transform.position;
        }

        target = positionCheck;
        currentPosition = target;
    }

    public void MovementSwitch()
    {
        allowMovement = allowMovement = true
            ? false
            : true;
    }
}
