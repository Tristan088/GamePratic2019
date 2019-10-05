using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="Settings/World")]
public class TextSettings : SingletonSettings<TextSettings>
{
    //Cette classe contiendra tout les textes du jeux. 
    //Syntaxe:  public string *nom_du_text* = "Le texte entre guillemet"


    public string textFinalDoorLock = "C'est fermé je ne peu pas m'échaper";
    public string textChaise = "On dirai la chaise de mon barbier à selzère";
    public string textTableChestWrong = "ça ne colle pas";
    public string textTableChestRight = "Il c'est passé quelque chose";

   
	 
}
