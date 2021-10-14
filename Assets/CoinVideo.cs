using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Video;

public class CoinVideo : MonoBehaviour
{
    [SerializeField] List<VideoPlayer> videoList;

    int random;
    System.Random randomMaker;

    private void Start()
    {
        randomMaker = new System.Random();
        random = randomMaker.Next(0, 2);
    }

    public void PlayCoin()
    {
        foreach (VideoPlayer player in videoList)
        {
            if (!player.isPlaying)
            {
                player.Play();
            }
        }
    }

}
