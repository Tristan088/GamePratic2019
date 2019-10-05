using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Text_Box : MonoBehaviour
{
    public Text InsideBox;
    public GameObject TextBox;
    public CanvasGroup DialogueCanvas;


    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        UndrawText();
    }

    public void DrawText(string mytext)
    {
        
        InsideBox.text = mytext;
        DialogueCanvas.alpha = 1;


    }

    public void UndrawText()
    {
        if (DialogueCanvas.alpha>=0)
        {
            DialogueCanvas.alpha -= 0.1f * Time.deltaTime;

        }
    }
}
