using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="Settings/World")]
public class TextSettings : SingletonSettings<TextSettings>
{


    
    //Cette classe contiendra tout les textes du jeux. 
    //Syntaxe:  public string *nom_du_text* = "Le texte entre guillemet"
    

    public string textFinalDoorLock = "C'est fermé je ne peux pas m'échaper";
    public string textBookWrong = "Aucune réaction...";
    public string textBookRight = "Quelque chose est tombé!";
    public string textBarberChair= "Cette chaise me rappelle un fauteuil de chez mon ami Gely à Pézenas.";
    public string textBarberKey = "Une clef ? Qu'est-ce qu'elle peut bien ouvrir ?";
    public string textCodeIsSeen = "4 chiffres? Une date? Un code?";
    public string textOpenTableLock = "2-0-1-9... ça s'ouvre";
    public string textTableLockCodeMissing = "Ce bureau est fermé par un code à 4 chiffres";
    public string textMap = "Montpellier, Pézenas, Béziers... Que de belles représentations en ses lieux";
    public string textTableChestWrong = "La clef ne colle pas";
    public string textTableChestRight = "La clef du fauteuil a marché, J'ai entendu quelque chose s'ouvrir";
    public string textTableChestKeyMissing = "C'est fermé, la clef ne doit pas être loin";
    public string textGetFinalKey = "C'est surment la clef de la sortie";




   





   
   
	 
}
