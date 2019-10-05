using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableChestLock : InteractableMother
{

    public bool isTheGoodOne;


  

    public override void Activate()
    {
        if (PlayerSettings.Instance.HaveKeyBarder)
        {
            if (isTheGoodOne)
            {
                PlayerSettings.Instance.EventTableChestUnlock();
            }
            else
            {
                //DrawText(TextSettings.instance.textTableChestWrong
            }
        }
        else
        {
            //DrawText Dont Have KeyBarber
        }
    }
}
