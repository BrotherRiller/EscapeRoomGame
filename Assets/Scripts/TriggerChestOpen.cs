using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChestOpen : MonoBehaviour
{
    [SerializeField] Animator myChest;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            myChest.Play("Chest Animation", 0, 0.0f);
            Destroy(this);
            Destroy(other.gameObject);
        }
    }
}
