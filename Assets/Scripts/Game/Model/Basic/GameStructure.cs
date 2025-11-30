using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class GameStructure
{
    private string _name;
    private List<Resource> _resources;
    private int _resourceCapacity;
    public Vector3 Position { get; private set; }

    public GameStructure(string name, int resourceCapacity, List<Resource> resources, Vector3 position)
    {
        _name = name;
        _resourceCapacity = resourceCapacity;
        _resources = resources;
        Position = position;
    }

    public void GetResource(Resource getRes)
    {
        _resources.Add(getRes);
    }

    public void SendResource(Resource sendRes, GameStructure anotherStruct)
    {
        if (_resources.Contains(sendRes) == true)
        {
            _resources.Remove(sendRes);
        }

        anotherStruct.GetResource(sendRes);
    }

    public bool RemoveResource(Resource removeRes)
    {
        if (_resources.Any(value => value.Name == removeRes.Name))
        {
            _resources.Remove(removeRes);
            return true;
        }
        return false;
        
    }
}
