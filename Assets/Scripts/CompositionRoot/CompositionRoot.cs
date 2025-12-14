using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositionRoot : MonoBehaviour
{
    [SerializeField] private InputService _inputService;
    private Builder _builder;
    private Connector _connector;

    private void Awake()
    {
        _builder = new Builder();
        _connector = new Connector(_inputService, _builder);
    }
}
