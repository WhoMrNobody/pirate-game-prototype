using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   
    private bool _dragPanMoveActive=false;
    private Vector2 _lastMousePos;
    private Vector3 inputDir = new Vector3(0, 0, 0);
    void Update()
    {
        

        if(Input.GetMouseButtonDown(1)){
            _dragPanMoveActive = true;
            _lastMousePos = Input.mousePosition;
        }
        if(Input.GetMouseButtonUp(1)){
            _dragPanMoveActive = false;
        }

        if(_dragPanMoveActive){

            Vector2 mouseMovementDelta = (Vector2)Input.mousePosition - _lastMousePos;

            float dragPanSpeed = 2f;
            inputDir.x = mouseMovementDelta.x * dragPanSpeed;
            inputDir.z = mouseMovementDelta.y * dragPanSpeed;

            _lastMousePos = Input.mousePosition;
        }

        HandleCameraRotation();

        HandleCameraMovement();
    }

    private void HandleCameraRotation(){

        float rotateDir = 0f;
        if(Input.GetKey(KeyCode.Q)) rotateDir = +1;
        if(Input.GetKey(KeyCode.E)) rotateDir = -1f;

        float rotateSpeed = 50f;
        transform.eulerAngles += new Vector3(0, rotateDir * rotateSpeed * Time.deltaTime, 0);
    }

    private void HandleCameraMovement(){

        

    }
}
