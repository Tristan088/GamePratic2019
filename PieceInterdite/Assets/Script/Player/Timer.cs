using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public AudioSource _audio;
    
    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerSettings.Instance.timerOn)
        {
            if (PlayerSettings.Instance.timer == 300)
            {
                _audio.Play();
            }
            if (PlayerSettings.Instance.timer == 150)
            {
                _audio.Play();
            }

                PlayerSettings.Instance.timer -= Time.deltaTime;


            if (PlayerSettings.Instance.timer < 0)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
