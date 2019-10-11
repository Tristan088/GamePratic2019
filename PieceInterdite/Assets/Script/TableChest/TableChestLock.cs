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
            if (isTheGoodOne )
            {
                
                PlayerSettings.Instance.EventTableChestUnlock();
                GetText(TextSettings.Instance.textGetFinalKey);
                gameObject.layer = 0;
            }
            else
            {
                
                GetText(TextSettings.Instance.textTableChestWrong);
            }
        }
        else
        {
            GetText(TextSettings.Instance.textTableChestKeyMissing);
        }
    }
}
