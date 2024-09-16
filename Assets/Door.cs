using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    public GameObject doorPivot;
    public Quaternion openRot;
    public Quaternion closeRot;

    public void DoorInteraction()
    {
        doorPivot.transform.rotation = doorPivot.transform.rotation == openRot ? closeRot : openRot;
    }
}
