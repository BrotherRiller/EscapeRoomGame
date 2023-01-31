using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPuzzle : MonoBehaviour
{
    [SerializeField] Animator myDoor;
    public void ActivateDoor()
    {
        myDoor.Play("SpaceDoorOpen3", 0, 0.0f);
        Destroy(this);
    }
}
