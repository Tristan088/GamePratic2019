﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="Settings/World")]
public class TextSettings : SingletonSettings<TextSettings>
{


    
    //Cette classe contiendra tout les textes du jeux. 
    //Syntaxe:  public string *nom_du_text* = "Le texte entre guillemet"
    

    public string textFinalDoorLock = "C'est fermé je ne peu pas m'échaper";
    public string textBarberChair= "Cette chaise me rappelle un fauteuil de chez mon ami Gely à Pézenas.";
    public string textBarberKey = "Une clef ? Qu'est-ce qu'elle peut bien ouvrir ?";
    public string textTableChestWrong = "La clef ne colle pas";
    public string textTableChestRight = "La clef du fauteuil a marché, J'ai entendu quelque chose s'ouvrir";
    public string textTableChestKeyMissing = "C'est fermé, la clef ne doit pas être loin";
    public string textGetFinalKey = "C'est surment la clef de la sortie";




   





   
   
	 
}
