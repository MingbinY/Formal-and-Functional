using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    public GameObject doorR;
    public GameObject doorL;

    public Quaternion openRot_R;
    public Quaternion closeRot_R;

    public Quaternion openRot_L;
    public Quaternion closeRot_L;

    public Material unlockedMat;
    public Material lockedMat;

    public void DoorInteraction()
    {
        doorR.transform.localRotation = doorR.transform.localRotation == openRot_R ? closeRot_R : openRot_R;
        doorL.transform.localRotation = doorL.transform.localRotation == openRot_L ? closeRot_L : openRot_L;
    }

    private void Update()
    {
        doorR.GetComponent<MeshRenderer>().material = canInteract ? unlockedMat : lockedMat;
        doorL.GetComponent<MeshRenderer>().material = canInteract ? unlockedMat : lockedMat;
    }
}
