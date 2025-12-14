using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connector
{
    private InputService _inputService;
    private Builder _builder;

    public Connector(InputService inputService, Builder builder)
    {
        _inputService = inputService;
        _builder = builder;

        inputService.mouseClicked += MakinStuff;
    }

    void MakinStuff(float x, float y)
    {
        _builder.Create(new Vector3(x, y, 0), null);
    }
}
