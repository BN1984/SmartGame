using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour//удал€й
{
    [SerializeField] private Camera m_Camera;
    [SerializeField] private float _speed;
    private float _speedUp;

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");//убирай //будем делать инпут сервис

        if(x != 0 || y != 0 )       
            _speedUp += _speed;      
        else                 
            _speedUp -= _speedUp / 2;

        transform.position += new Vector3(x * _speedUp, y * _speedUp);
    }
}
