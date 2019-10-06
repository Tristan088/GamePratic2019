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

    public float timer = 300f;

    public bool timerOn = false;


   


    private void OnEnable()
    {
        timerOn = false;
        timer = 300;
        HaveFinalKey = false;
        HaveKeyBarder = false;
        HaveCode = false;
        bookCount = 0;
        bookValide = true;
    }






    public void EventBook(int n)
    {
        bookCount++;
        if (bookCount != n)
        {
            bookValide = false;
        }
       
        
        if (bookCount == 4)
        {
            if (bookValide)
            {

            }
            else
            {
                bookCount = 0;
                bookValide = true;

            }
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
        SceneManager.LoadScene(1);
    }

}
