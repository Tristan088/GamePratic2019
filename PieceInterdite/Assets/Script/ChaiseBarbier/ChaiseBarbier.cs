using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaiseBarbier : InteractableMother
{
    

    

    public override void Activate()
    {
        GetText(TextSettings.Instance.textBarberChair);
    }
}

