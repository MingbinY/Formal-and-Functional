using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeper : Interactable
{
    public GameObject markImage;
    public GameObject hiddenPathHint;
    public Door doorToShow;
    public GameObject wallToHide;

    public void ShowHint()
    {
        canInteract = false;

        markImage.SetActive(false);
        hiddenPathHint.SetActive(true);
        wallToHide.SetActive(false);
        doorToShow.gameObject.SetActive(true);
        doorToShow.canInteract = true;
    }

}
