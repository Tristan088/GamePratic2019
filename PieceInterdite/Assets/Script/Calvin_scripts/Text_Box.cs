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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //DialogueCanvas.alpha = 1;
            DrawText("helloworld");
        }
           // if (Input.GetKeyDown(KeyCode.Space))
        //{
           // DialogueCanvas.alpha = 0; 
        //}

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
            DialogueCanvas.alpha -= 0.2f * Time.deltaTime;

        }
    }
}
