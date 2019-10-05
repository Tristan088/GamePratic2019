using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPorte : InteractableMother
{
    public override void Activate()
    {
        if(PlayerSettings.Instance.HaveFinalKey)
        {
            PlayerSettings.Instance.EventFinishGame();
        }
        else
        {
            
        }
    }

}
