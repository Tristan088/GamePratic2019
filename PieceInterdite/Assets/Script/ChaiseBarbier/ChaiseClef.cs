using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaiseClef : InteractableMother
{
    // Start is called before the first frame update

    public AudioSource _audio;
    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Activate()
    {
        PlayerSettings.Instance.HaveKeyBarder = true;
        GetText(TextSettings.Instance.textBarberKey);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
        _audio.Play();
        Destroy(gameObject, 2f);
       
    }
}
