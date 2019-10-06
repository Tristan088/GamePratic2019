using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMannager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerSettings.Instance.timer>0)
        {
            text.text = "Voilà de quoi écrire une belle pièce, mais le public n’y croira jamais, je garde donc cette aventure secrète, caché du temps que le public puisse l’apprécier à sa juste valeur.";

        }
        else
        {
            text.text = "Un coup sec, un long silence et le rideau tombe pour notre dramaturge. Cette pièce gardera ses secrets encore quelque temps";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Text text;

    public void ByeBye()
    {
        Application.Quit();

    }

    public void Retry()
    {
        PlayerSettings.Instance.ResetPlayer();
        SceneManager.LoadScene(0);

    }
   
}
