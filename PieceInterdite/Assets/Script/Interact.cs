using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{


    //Distance d'intéraction du joueur
    public float range;
   //Ray du raycast pour la detection de l'objet
    private Ray ray;
    //information sur l'objet touché par le raycast
    private RaycastHit hit;
    //Layer des objects intéragibles
    public LayerMask mask;


    // Start is called before the first frame update


   

    // Update is called once per frame
    void Update()
    {

        //Si on clique Gauche
        if(Input.GetMouseButtonDown(0))
        {
            if(ObjectInRange())
            {
                //on lance la fonction d'interaction de l'objet
                hit.collider.gameObject.GetComponent<InteractableMother>().Activate();
            }
        }
    }


    /// <summary>
    /// Fonction qui renvoie true si le joueur regarde un objet intéractible et qu'il est à porter. 
    /// </summary>
    /// <returns></returns>
    bool ObjectInRange()
    {
        ray = new Ray(transform.position, transform.forward);
        return Physics.Raycast(ray, out hit, range, mask);
    }
}
