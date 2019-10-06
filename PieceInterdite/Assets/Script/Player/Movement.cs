using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public int speed;
    public Rigidbody rb;
    private Vector3 direction;
    private AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        direction = Vector3.zero;
        
        
        if (Input.GetKey(KeyCode.Z))
        {
            direction += transform.forward ;
        }
         if(Input.GetKey(KeyCode.Q))
        {
            direction += -transform.right ;
        }
         if (Input.GetKey(KeyCode.D))
        {
            direction += transform.right;
        }
         if (Input.GetKey(KeyCode.S))
        {
            direction += -transform.forward ;
        }

         if(direction != Vector3.zero )
        {
            if(!_audio.isPlaying)
            {
                _audio.Play();
            }
            
        }
        else
        {
            _audio.Stop();
        }
        direction.Normalize();
        rb.velocity = direction * speed * Time.deltaTime;
    }
}
