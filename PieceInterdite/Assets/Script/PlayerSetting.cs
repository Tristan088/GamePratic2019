using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Settings/World")]
public class PlayerSettings : SingletonSettings<PlayerSettings>
{
    //Ce scriptableObject contiendra tout les booleen sur l'avancement des énigmes du player


    public bool HaveKeyBarder = false;

    public bool HaveFinalKey = false;








    public void EventTableChestUnlock()
    {
        HaveFinalKey = true;
        //DrawText
    }

    public void EventFinishGame()
    {
        Debug.Log("GG");
    }

}
