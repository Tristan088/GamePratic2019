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
        _audio.Play();
        rotate = true;
        GetText(TextSettings.Instance.textLevier);
        

    }

    private void Update()
    {
        if(rotate && (transform.rotation.eulerAngles.x >= 271 || transform.rotation.eulerAngles.x == 0))
        {
            transform.Rotate(Vector3.right, speed * Time.deltaTime);

        }
    }
}
