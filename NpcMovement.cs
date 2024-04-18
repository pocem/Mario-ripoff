using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NpcMovement : MonoBehaviour
{
    public Transform platform;
    public Transform startPoint;
    public Transform endPoint;
    int direction = 1;
    public float speed = 1.5f;
    private void OnDrawGizmos()
    {
        if (platform != null && startPoint != null && endPoint != null)
            Gizmos.DrawLine(platform.transform.position, startPoint.position);
            Gizmos.DrawLine(platform.transform.position, endPoint.position);
    }
    private void Update()
    {
        MovePlatform();
    }
    void MovePlatform()
    {
        Vector2 target = currentMovementTarget();
        platform.position = Vector2.MoveTowards(platform.position, target, speed * Time.deltaTime);

        float distance = (target - (Vector2)platform.position).magnitude;

        if (distance <= 0.1f)
        {
            // Change direction when reaching the target
            ChangeDirection();
        }
    }
    void ChangeDirection()
    {
        if (direction == 1){direction = -1;}
        else  { direction = 1;}
    }
    Vector2 currentMovementTarget()
    {
        if (direction == 1){return startPoint.position; }
        else{return endPoint.position;}
    }
}
