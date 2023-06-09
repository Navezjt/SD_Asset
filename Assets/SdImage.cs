﻿using UnityEngine;

[System.Serializable]
public class SdImage
{
    public Texture2D   image;
    public string data;

    public SdImage(Texture2D image, string data)
    {
        this.image = image;
        this.data  = data;
    }
}