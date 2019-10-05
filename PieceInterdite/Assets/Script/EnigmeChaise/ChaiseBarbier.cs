using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaiseBarbier : InteractableMother
{
    

    

    public override void Activate()
    {
        Debug.Log(TextSettings.Instance.textChaise);
    }
}

