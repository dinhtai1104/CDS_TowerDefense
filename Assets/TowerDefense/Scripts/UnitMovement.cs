using System;
using UnityEngine;

public class UnitMovement : MonoBehaviour
{
    // Enemy di chuyen tu  diem A den B
    public Path path;
    public int currentGoalIndex = 1;

    public float speed;

    private void Start()
    {
        transform.position = path.points[0].position;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        //var direction = pointB.position - pointA.position;
        //transform.position += direction.normalized * speed * Time.deltaTime;

        if (currentGoalIndex >= path.points.Length)
        {
            return;
        }

        var goal = path.points[currentGoalIndex]; // length - 1
        transform.position = Vector3.MoveTowards(transform.position, goal.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, goal.position) <= 0.05f)
        {
            transform.position = path.points[currentGoalIndex].position;
            currentGoalIndex++;
        }
    }
}