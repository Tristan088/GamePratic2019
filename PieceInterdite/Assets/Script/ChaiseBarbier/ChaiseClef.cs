﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaiseClef : InteractableMother
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Activate()
    {
        PlayerSettings.Instance.HaveKeyBarder = true;
        GetText(TextSettings.Instance.textBarberKey);
        gameObject.SetActive(false);
       
    }
}
