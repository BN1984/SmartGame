using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBuilding
{
    private GameStructure startStructure;
    private GameStructure endStructure;

    public void Create(Vector3 position, GameStructure another)
    {
        if (another != null)
        {
            if(another is City)
            {
                if (startStructure == null)
                    startStructure = another;
                else
                    CreateRoad(startStructure, endStructure, 100, startStructure.Name + "-" + endStructure.Name + " дорога");
            }
        }
        else
            CreateCity(position);
    }

    private void CreateCity(Vector3 position)
    {
        City city = new City("Город", Random.Range(100, 10000), null, position, 1);
    }

    private void CreateRoad(GameStructure startObject, GameStructure endObject, int conductivity, string name)
    {
        Road road = new Road(endObject, startObject, conductivity, name);

        
    }
}
