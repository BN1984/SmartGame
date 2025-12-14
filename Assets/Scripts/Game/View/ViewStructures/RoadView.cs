using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadView
{
    private Road _road;

    public RoadView(Road road)
    {
        _road = road;
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawLine(_road.ConnectTo.Position, _road.ConnectFrom.Position);
    }
}
