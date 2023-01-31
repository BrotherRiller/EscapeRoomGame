using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePuzzle : MonoBehaviour
{
    [SerializeField] Animator myDoor;
    public void ActivateDoor()
    {
        myDoor.Play("SpaceDoorOpen2", 0, 0.0f);
        Destroy(this);
    }
}
