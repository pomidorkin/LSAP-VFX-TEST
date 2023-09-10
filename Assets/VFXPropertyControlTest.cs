using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFXPropertyControlTest : MonoBehaviour
{
    [SerializeField] private VisualEffect testVfx;
    public int band;
    public float startScale, scaleMultiplier;
    [SerializeField] bool useBuffer = true;
    private float bandMax = 0.01f;

    void Update()
    {
        float currentBand = AudioPeer.bandBuffer[band];
        if (currentBand > bandMax)
        {
            bandMax = currentBand;
        }

        testVfx.SetFloat("Rate", (currentBand / bandMax));
    }/*
    // Start is called before the first frame update
    void Start()
    {
        testVfx.SetFloat("Rate", newRate);
    }*/
}
