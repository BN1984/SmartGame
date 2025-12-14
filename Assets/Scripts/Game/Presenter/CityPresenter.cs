using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityPresenter
{
    private GameObject _cityView;
    private City _city;

    public CityPresenter(City city, GameObject cityView)
    { 
        _city = city;
        _cityView = cityView;

        CityType type = _cityView.AddComponent<CityType>();

        type.Presenter = this;
    }

    public City GetCity()
    {
        return _city;
    }
}
