using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityView : MonoBehaviour
{
    private GameObject _city;

    public CityView(GameObject city)
    {
        _city = city;
    }

    public GameObject CreateView(Vector3 position)
    {
        GameObject cityObject = Instantiate(_city, position, Quaternion.identity);
        return cityObject;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        //Gizmos.DrawLine()
    }
}
