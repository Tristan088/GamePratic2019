using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaiseClef : InteractableMother
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Activate()
    {
        PlayerSettings.Instance.HaveKeyBarder = true;
        gameObject.SetActive(false);
       
    }
}
