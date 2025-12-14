using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityType : MonoBehaviour
{
    public CityPresenter Presenter { get; set; }

    public CityType(CityPresenter presenter)
    {
        Presenter = presenter;
    }
}
