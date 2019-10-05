using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerZ : MonoBehaviour
{



    public float aimAssistCameraSpd = 80.0f;
    public float speed = 10.0f;
    public float CurrentCamSpeed = 110.0f;
    public float CameraSpeed = 110.0f;
    public float mousePosx = 0.0f;
    public float mousePosy = 0.0f;
    private Camera cam;
    public LayerMask plus3;
    public float ScopeSpeed = 2.0f;

    void Start()
    {
        cam = Camera.main;
    }
    public void Move(Vector3 _direction, float _deltaTime)
    {
        //transform.position = transform.position + Vector3.forward * speed * Time.deltaTime;


        _direction.Normalize();

        transform.position += _direction * speed * Time.fixedDeltaTime;


    }
    void FixedUpdate()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hitInfo;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, Mathf.Infinity, plus3))
        {

            Debug.Log("hitcenter");
            Debug.DrawRay(cam.transform.position, cam.transform.forward, Color.cyan);
            Debug.DrawLine(cam.transform.position, hitInfo.point, Color.cyan);
            CurrentCamSpeed = aimAssistCameraSpd;

        }
        else
        {
            CurrentCamSpeed = CameraSpeed;
        }

        if (Input.GetButton("Fire2"))
        {
            CameraSpeed = 70.0f;
        }
        else
        {
            CameraSpeed = 110.0f;

        }
    }
    private void LateUpdate()
    {


        transform.Rotate(Vector3.up * CurrentCamSpeed * (Input.GetAxis("Mouse X")) * Time.deltaTime);








    }

}
