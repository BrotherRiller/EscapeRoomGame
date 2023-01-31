using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    [SerializeField] Animator doorOpen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BigKey"))
        {
            doorOpen.Play("DoorOpen");
            Destroy(this);
            Destroy(other.gameObject);
        }
    }
}
