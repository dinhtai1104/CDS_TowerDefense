using UnityEngine;

public class Path : MonoBehaviour
{
    public Transform[] points;

    private void OnDrawGizmos()
    {
        var startPos = points[0].position;
        for (int i = 1; i < points.Length; i++)
        {
            var targetPos = points[i].position;
            Gizmos.DrawLine(startPos, targetPos);
            startPos = targetPos;
        }
    }
}