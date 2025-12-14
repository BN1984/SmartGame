using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalConstruction : Resource
{
    public string Name { get; set; }
    public int Amount { get; set; }

    public MetalConstruction(string name, int amount) : base(name, amount)
    {
        Name = name;
        Amount = amount;
    }
}
