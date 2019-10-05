using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//CLasse mère des object intéractibles
public abstract  class  InteractableMother : MonoBehaviour
{

    private GameObject text_box;

    private void Start()
    {
        gameObject.layer = 9;
        text_box = GameObject.Find("TextBox");
    }

    //Fonction virtual qui sera redéfinie dans chaque sous classe des différents objets. C'est elle qui sera appelé et effectura les effets des objets.
    public virtual void Activate() { }


    //Fonction qui permet de retourner un text pour la fonction d'affichage de text. Les text doivent être paramétré dans  TextSettings et passer en paramètre de la manière suivante :
    //TextSettings.Intstance.*nom_de_la_varibale_text*
    public  void GetText(string myText)
    {
        text_box.GetComponent<Text_Box>().DrawText(myText);
    }
   
}
