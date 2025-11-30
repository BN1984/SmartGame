using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class City : GameStructure
{
    private string _name;
    private int _resourceCapacity;
    private List<Resource> _resources;
    private Vector3 _position;
    private float _size;
    private List<Road> _roads;

    public City(string name, int resourceCapacity, List<Resource> resources, Vector3 position, float size) : base(name, resourceCapacity, resources, position)
    {
        _name = name;
        _resourceCapacity = resourceCapacity;
        _resources = resources;
        _position = position;
        _size = size;
    }

    public void GeneratePeople()
    {
        int people = 100 * Convert.ToInt32(_size);
        _resources.Add(new People("Люди", people));
    }

    public void Resize()
    {

    }

    public void InstructionsToSend()
    {

    }
}
