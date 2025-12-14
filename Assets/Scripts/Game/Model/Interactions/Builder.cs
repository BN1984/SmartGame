using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder//Factory //GameplayFactory
{

    public City CreateCity(Vector3 position)
    {
        City city = new City("Город", Random.Range(100, 10000), null, position, 1);
        Debug.Log($"City created at {position.x}, {position.y}");
        return city;
    }

    public Road CreateRoad(GameStructure startObject, GameStructure endObject, int conductivity, string name)
    {
        Road road = new Road(endObject, startObject, conductivity, name);
        return road;      
    }
}
