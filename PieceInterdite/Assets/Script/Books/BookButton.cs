﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookButton : InteractableMother
{


    public GameObject Tableau;
    public  GameObject newTableau;
    public GameObject[] allBook;
    public GameObject textCode;
    public AudioSource _audio;
    private Renderer _renderer;
    public Material _green;
    public Material _black;



    public int order;
    // Start is called before the first frame update
    public void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _audio = GetComponent<AudioSource>();

       
    }

    // Update is called once per frame

    public override void Activate()
    {
        _audio.Play();
        _renderer.material = _green;
        
        PlayerSettings.Instance.EventBook(order);
        if(PlayerSettings.Instance.bookCount == 0)
        {
            GetText(TextSettings.Instance.textBookWrong);
            foreach(GameObject g in allBook)
            {
                g.GetComponent<Renderer>().material = _black;
            }
        }
        else if (PlayerSettings.Instance.bookCount == 4)
        {
            GetText(TextSettings.Instance.textBookRight);
            Tableau.SetActive( false);
            newTableau.SetActive(true);
            textCode.SetActive(true);

           foreach(GameObject b in allBook)
            {
                b.GetComponent<Collider>().enabled = false;
            }

        }
       
    }
}