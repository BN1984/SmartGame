using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Resource
{
    public string Name { get; set; }
    public int Amount { get; set; }

    public Food(string name, int amount) : base(name, amount)
    {
        Name = name;
        Amount = amount;
    }
}
