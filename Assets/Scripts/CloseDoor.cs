using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    [SerializeField] string AnimationName;
    [SerializeField] Animator myDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myDoor.Play(AnimationName, 0, 0.0f);
            Destroy(this);
        }
    }
}
