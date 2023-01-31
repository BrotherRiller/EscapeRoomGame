using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schalter : MonoBehaviour
{
    [SerializeField] GameObject Check1;
    [SerializeField] GameObject Check2;
    [SerializeField] GameObject Check3;
    [SerializeField] GameObject Check4;

    [SerializeField] Animator schaltung;

    // Update is called once per frame
    void Update()
    {
        if (Check1.transform.localRotation.eulerAngles.y == 180)
        {
            Debug.Log("Check1");
            if (Check2.transform.localRotation.eulerAngles.y == 300)
            {
                Debug.Log("Check2");
                
                if (Check3.transform.localRotation.eulerAngles.y == 90)
                {
                    Debug.Log("Check3");
                    Debug.Log(Check4.transform.localRotation.eulerAngles.y);
                    if (Check4.transform.localRotation.eulerAngles.y == 0)
                    {
                        Debug.Log("Kam es durch?");
                        schaltung.Play("SchalterOpen", 0, 0.0f);
                        Destroy(this);
                    }
                }
            }
        }
    }
}
