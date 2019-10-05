using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDesk : MonoBehaviour
{

    public bool isOpen = false;
    public float speedRotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //angle -= speedRotate * Time.deltaTime;
        //transform.rotation = Quaternion.AngleAxis(angle, transform.forward);

        if (isOpen && ( transform.rotation.eulerAngles.x >= 271 || transform.rotation.eulerAngles.x==0))
        {
          transform.Rotate(-speedRotate*Time.deltaTime, 0f, 0f);
        }

        


    }
}
