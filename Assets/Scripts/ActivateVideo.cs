using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateVideo : MonoBehaviour
{
    [SerializeField] GameObject Video;
    [SerializeField] GameObject Player;

    public void ButtonPressed()
    {
        Video.SetActive(true);
        Player.SetActive(true);
    }
    
}
