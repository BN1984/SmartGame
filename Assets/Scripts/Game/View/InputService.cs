using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class InputService : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    private Vector2 _direction = new Vector2(0, 0);

    public event Action<float, float, GameStructure> mouseClicked; 

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, _direction);

            if(hit.collider == null)
            {
                mouseClicked(mousePos.x, mousePos.y, null);
            }
            else if(hit.collider.name == "City(Clone)")
            {
                mouseClicked(mousePos.x, mousePos.y, hit.collider.gameObject.GetComponent<CityType>().Presenter.GetCity());
                Debug.Log("Clicked city");
            }
        }
    }
}
