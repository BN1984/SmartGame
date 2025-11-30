using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Resource
{
    public string Name { get; private set; }
    public int Amount { get; private set; }

    public Resource(string name, int amount)
    {
        Name = name;
        Amount = amount;
    }
}
