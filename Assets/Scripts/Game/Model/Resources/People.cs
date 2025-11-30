using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : Resource
{
    public string Name { get; set; }
    public int Amount { get; set; }

    public People(string name, int amount) : base(name, amount)
    {
        Name = name;
        Amount = amount;
    }
}
