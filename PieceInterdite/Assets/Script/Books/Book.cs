using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : InteractableMother
{

    public int n;
    private AudioSource _audio;
    // Start is called before the first frame update


    // Update is called once per frame
    public void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    public override void Activate()
    {
    
        switch(n)
        {

            case 1:
                GetText(TextSettings.Instance.textBook1);
                break;
            case 2:
                GetText(TextSettings.Instance.textBook2);
                break;
            case 3:
                GetText(TextSettings.Instance.textBook3);
                break;
            case 4:
                GetText(TextSettings.Instance.textBook4);
                break;

        }

        _audio.Play();
    }
}
