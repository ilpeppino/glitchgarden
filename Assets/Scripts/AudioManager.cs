﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        StartMusic();
    }

    private void StartMusic()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}

