using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ServiceLocator
{
    private static Dictionary<Type, object> _instances = new();

    public static void Register<TInstance>(TInstance instance)
    {
        _instances.TryAdd(typeof(TInstance), instance);
    }

    public static TInstance Get<TInstance>()
    {
        if (_instances.TryGetValue(typeof(TInstance), out object value) == false)
            throw new Exception($"{typeof(TInstance)} not found");

        return (TInstance)value;
    }
}
