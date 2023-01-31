using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] GameObject check;
    [SerializeField] Vector3 _rotation;

    private void Update()
    {
        if (check.transform.localRotation.eulerAngles.y >= 360)
        {
            check.transform.Rotate(0, 0, 0);
        }
    }
    public void RotateObject()
    {
        check.transform.Rotate(_rotation);
    }
}
