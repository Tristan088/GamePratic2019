using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levier : InteractableMother
{
    // Start is called before the first frame update

    public GameObject aFaireDisparaitre;
    public GameObject aFaireApparaitre;
    public AudioSource _audio;
    public bool rotate;
    public float speed;

    public override void Activate()
    {

        GetComponent<Collider>().enabled = false;
        aFaireApparaitre.SetActive(true);
        aFaireDisparaitre.SetActive(false);
        PlayerSettings.Instance.timerOn = true;
        _audio.Play();
        rotate = true;
        GetText(TextSettings.Instance.textLevier);
        

    }

    private void Update()
    {
        if(rotate && (transform.rotation.eulerAngles.x <= 70 || transform.rotation.eulerAngles.x == 0))
        {
            transform.Rotate(Vector3.right, -speed * Time.deltaTime);

        }
    }
}
