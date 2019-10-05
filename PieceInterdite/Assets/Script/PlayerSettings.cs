using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "Settings/Player")]
public class PlayerSettings : SingletonSettings<PlayerSettings>
{
    //Ce scriptableObject contiendra tout les booleen sur l'avancement des énigmes du player


    public bool HaveKeyBarder = false;

    public bool HaveFinalKey = false;

    public bool HaveCode = false;


    private void OnEnable()
    {
        HaveFinalKey = false;
        HaveKeyBarder = false;
        HaveCode = false;
    }
    
    






    public void EventTableChestUnlock()
    {
        if (!PlayerSettings.Instance.HaveFinalKey)
        {
            HaveFinalKey = true;
        }
       
       
    }

    public void EventFinishGame()
    {
        Debug.Log("GG");
    }

}
