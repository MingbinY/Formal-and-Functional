using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    public float interactionDist = 5f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, interactionDist))
            {
                Interactable hitInteractable = hit.collider.GetComponent<Interactable>();
                if ( hitInteractable != null)
                {
                    hitInteractable.TriggerInteractEvent();
                }
            }
        }
    }
}
