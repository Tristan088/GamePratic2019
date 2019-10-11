using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerY : MonoBehaviour
{
  
    public float speed = 10.0f;
    public float regularCameraSpeed = 4.0f;
    public float aimCameraSpeed = 95.0f;
    float currentCameraSpeed = 110.0f;
    public float mousePosx = 0.0f;
    public float mousePosy = 0.0f;
    
    public LayerMask plus3;
    public float aimAssistCameraSpeed = 0.1f;
    public float viewRange = 5.0f;
    public float viewHalfAngle = 120.0f;
    public float currentY = 0f;
    float currentRotationX = 0.0f;
    public float limitCamera = 90f;
    public GameObject AimObject;
    private Camera cam;

        public void Move(Vector3 _direction, float _deltaTime)
    {
        //transform.position = transform.position + Vector3.forward * speed * Time.deltaTime;


        _direction.Normalize();

        transform.position += _direction * speed * Time.fixedDeltaTime;


    }


    void Update()
    {

        currentY = Input.GetAxis("Mouse Y");


        if (Input.GetButton("Fire2"))
        {
            regularCameraSpeed = aimCameraSpeed;
        }
        else
        {
            regularCameraSpeed = currentCameraSpeed;
        }
        currentRotationX = currentRotationX + currentY * regularCameraSpeed * Time.deltaTime;
        currentRotationX = Mathf.Clamp(currentRotationX, -limitCamera, limitCamera);

    }
    //void FixedUpdate()
    //{
    //    Ray ray = new Ray(cam.transform.position, cam.transform.forward);
    //    RaycastHit hitInfo;
    //    if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, Mathf.Infinity, plus3))
    //    {

    //        Debug.Log("OkY");
    //        Debug.DrawRay(cam.transform.position, cam.transform.forward, Color.red);
    //        Debug.DrawLine(cam.transform.position, hitInfo.point, Color.red);
    //        currentCameraSpeed = aimCameraSpeed;

    //    }
    //    else
    //    {
    //        currentCameraSpeed = normalCameraSpeed;
    //    }
    //}
    private void LateUpdate()
    {
        
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.x = -currentRotationX;
        transform.eulerAngles = currentRotation;

        //Quaternion rotation = Quaternion.AngleAxis(currentRotationX, Vector3.left);
        //transform.rotation = transform.rotation * rotation;
        //Quaternion quaternion = Quaternion.Euler(0, 0, currentY);
        //transform.position = transform.position + quaternion *  new Vector3(0,0,0);
       // transform.Rotate(Vector3.left * CameraSpeed * (currentY));
        //currentY += CameraSpeed;
        //currentY = Mathf.Clamp(CameraSpeed, -90f, 90f);

        //transform.localEulerAngles - new Vector3(currentY, 0f, 0f);
    }

}
