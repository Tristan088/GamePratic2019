using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : InteractableMother
{
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void  Activate()
    {
        Debug.Log("Je Fait Mon Effet");
    } 
}
