using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeImage : InteractableMother
{
    // Start is called before the first frame update


    // Update is called once per frame
    public override void Activate()
    {
        if (!PlayerSettings.Instance.HaveCode)
        {
            PlayerSettings.Instance.HaveCode = true;
            GetText(TextSettings.Instance.textCodeIsSeen);
        }

    }
}
