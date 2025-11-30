using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using UnityEngine;

public class Road
{
    private List<Package> _resources;
    private GameStructure _connectTo;
    private GameStructure _connectFrom;
    private int _conductivity;
    private float _length;
    public string Name { get; private set; }

    public Road(GameStructure connectTo, GameStructure connectFrom, int conductivity, string name)
    {
        Name = name;
        _conductivity = conductivity;
        _connectTo = connectTo;
        _connectFrom = connectFrom;
        _length = Vector3.Distance(_connectFrom.Position, _connectTo.Position);
        _resources = new List<Package>();
    }

    public void SendRes(bool toObject, Resource resource)
    {
        float time = _length * resource.Amount / _conductivity;
        GameStructure getter = _connectFrom;
        Waiter(_connectFrom, resource, time);
    }

    public async void Waiter(GameStructure getter, Resource res, float time)
    {
        await Task.Delay(Convert.ToInt32(time * 1000));
        getter.GetResource(res);
    }

    private class Package
    {
        private DateTime _time;
        private List<Resource> _resources;
    }
}
