using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{
    [SerializeField] Animator button;
    [SerializeField] Animator schaltung;
    public void TriggerSchaltung()
    {
        Debug.Log("Test");
        button.Play("ButtonPress", 0, 0.0f);
        schaltung.Play("TombOpen", 0, 0.0f);
        Destroy(this);
    }
}
