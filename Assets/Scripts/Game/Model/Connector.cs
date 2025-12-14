using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connector
{
    private InputService _inputService;
    private Builder _builder;
    private CityView _cityView;

    private GameStructure startStructure;
    private GameStructure endStructure;

    public Connector(InputService inputService, Builder builder, CityView cityView)
    {
        _inputService = inputService;
        _builder = builder;
        _cityView = cityView;

        inputService.mouseClicked += Create;      
    }

    public void Create(float x, float y, GameStructure another)
    {
        Vector3 position = new Vector3(x, y, 0);

        if (another != null)
        {
            if (another is City)
            {
                if (startStructure == null)
                    startStructure = another;
                else if (startStructure == endStructure)
                {
                    startStructure = null;
                    endStructure = null;
                }
                else
                {
                    endStructure = another;
                    Debug.Log(startStructure);
                    Debug.Log(endStructure);
                    Road road = _builder.CreateRoad(startStructure, endStructure, 100, startStructure.Name + "-" + endStructure.Name + " дорога");
                    RoadView roadView = new RoadView(road);
                    RoadPresenter roadPresenter = new RoadPresenter(road, roadView);
                    startStructure = null;
                    endStructure = null;
                }
            }
        }
        else
        {
            CityPresenter cityPresenter = new CityPresenter(_builder.CreateCity(position), _cityView.CreateView(position));
        }
    }
}
