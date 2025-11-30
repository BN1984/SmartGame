using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : GameStructure
{
    private string _name;
    private int _resourceCapacity;
    private List<Resource> _resources;
    private Vector3 _position;

    public Factory(string name, int resourceCapacity, List<Resource> resources, Vector3 position) : base(name, resourceCapacity, resources, position)
    {
        _name = name;
        _resourceCapacity = resourceCapacity;
        _resources = resources;
        _position = position;
    }

    public void Craft()
    {
        
    }
}
