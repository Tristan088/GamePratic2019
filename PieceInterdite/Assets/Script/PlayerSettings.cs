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

    public int bookCount = 0;

    public bool bookValide = true;


    private void OnEnable()
    {
        HaveFinalKey = false;
        HaveKeyBarder = false;
        HaveCode = false;
        bookCount = 0;
        bookValide = true;
    }






    public void EventBook(int n)
    {
        bookCount++;
        if(bookCount == 4)
        {
            if(bookValide)
            {
                
            }
            else
            {
                bookCount = 0;
                bookValide = true;
                
            }
        }
        else if (bookCount != n)
        {
            bookValide = false;
        }
        return;

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
