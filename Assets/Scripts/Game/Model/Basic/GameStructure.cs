using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class GameStructure
{
    private List<Resource> _resources;
    private int _resourceCapacity;
    public Vector3 Position { get; private set; }
    public string Name { get; private set; }
    public List<Road> Roads { get; private set; }//убрать

    public GameStructure(string name, int resourceCapacity, List<Resource> resources, Vector3 position)
    {
        Name = name;
        _resourceCapacity = resourceCapacity;
        _resources = resources;
        Position = position;
        Roads = new List<Road>();
    }

    public void GetResource(Resource getRes)//Set
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

    public void AddRoad(Road road)
    {
        Roads.Add(road);
    }

    public void RemoveRoad(string name)
    {
        for (int i = 0; i < Roads.Count; i++)
        {
            if (Roads[i].Name == name)
            {
                Roads.RemoveAt(i);
            }
        }
    }
}
