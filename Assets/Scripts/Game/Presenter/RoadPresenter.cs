using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadPresenter
{
    private RoadView _roadView;
    private Road _road;

    public RoadPresenter(Road road, RoadView roadView)
    {
        _road = road;
        _roadView = roadView;       
        _roadView.OnDrawGizmos();
    }
}
