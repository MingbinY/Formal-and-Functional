using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeper : Interactable
{
    public GameObject markImage;
    public GameObject hiddenPathHint;

    public void ShowHint()
    {
        canInteract = false;

        markImage.SetActive(false);
        hiddenPathHint.SetActive(true);
    }

}
