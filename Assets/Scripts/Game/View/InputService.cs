using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class InputService : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    public event Action<float, float> mouseClicked; 

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
            mouseClicked(mousePos.x, mousePos.y);
        }
    }
}
