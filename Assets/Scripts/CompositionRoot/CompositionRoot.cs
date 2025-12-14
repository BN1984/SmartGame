using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositionRoot : MonoBehaviour
{
    [SerializeField] private InputService _inputService;
    [SerializeField] private GameObject _cityPrefab;
    private Builder _builder;
    private Connector _connector;
    private CityView _cityView;

    private void Awake()
    {
        _builder = new Builder();
        _cityView = new CityView(_cityPrefab);

        _connector = new Connector(_inputService, _builder, _cityView);
    }
}
