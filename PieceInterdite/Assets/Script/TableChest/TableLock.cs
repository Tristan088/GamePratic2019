using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableLock : InteractableMother
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        

    }

    public override void Activate()
    {
        if(PlayerSettings.Instance.HaveCode)
        {
            
        }
    }
}
