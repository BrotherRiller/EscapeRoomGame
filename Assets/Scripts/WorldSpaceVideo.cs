using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WorldSpaceVideo : MonoBehaviour
{
    [SerializeField] GameObject video;
    [SerializeField] GameObject player;
    [SerializeField] Animator buttonPress;

    private VideoPlayer videoPlayer;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void Play()
    {
        buttonPress.Play("pressButton", 0, 0.0f);
        video.SetActive(true);
        player.SetActive(true);
        videoPlayer.Play();
        Destroy(this);
    }
}
