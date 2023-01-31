using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject tester;
    public void Testing()
    {
        Debug.Log("Erfolgreich zerstört");
        Destroy(tester);
    }
}
