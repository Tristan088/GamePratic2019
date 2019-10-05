using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableLock : InteractableMother
{
    // Start is called before the first frame update


    public GameObject map;
    public GameObject[] locks;
    public GameObject tableTop;

    // Update is called once per frame
    void Update()
    {
        

    }

    public override void Activate()
    {
        if(PlayerSettings.Instance.HaveCode)
        {
            //Ouverture Etagère
            GetText(TextSettings.Instance.textOpenTableLock);
            map.SetActive(true);
            foreach(GameObject g in locks)
            {
                g.SetActive(true);
            }
            tableTop.GetComponent<TopDesk>().isOpen = true;
            Destroy(gameObject);
            
        }
        else
        {
            GetText(TextSettings.Instance.textTableLockCodeMissing);
        }
    }
}
