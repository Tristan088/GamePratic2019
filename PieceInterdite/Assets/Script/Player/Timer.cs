using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerSettings.Instance.timerOn)
        {
            PlayerSettings.Instance.timer -= Time.deltaTime;

            if (PlayerSettings.Instance.timer < 0)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
