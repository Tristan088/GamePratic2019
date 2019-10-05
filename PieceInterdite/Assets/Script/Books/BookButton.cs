using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookButton : InteractableMother
{


    public GameObject Tableau;
    public  GameObject newTableau;
    public GameObject[] allBook;
    public GameObject textCode;



    public int order;
    // Start is called before the first frame update


    // Update is called once per frame

    public override void Activate()
    {
        PlayerSettings.Instance.EventBook(order);
        if(PlayerSettings.Instance.bookCount == 0)
        {
            GetText(TextSettings.Instance.textBookWrong);
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
