using UnityEngine;
using System.Collections;

public class windSounds : MonoBehaviour
{
    ParticleSystem dust;
    AudioSource wind;

    const float min_vol = (float) 0.02;
    const float max_vol = (float) 0.5;

    // Use this for initialization
    void Start()
    {
        dust = GetComponent<ParticleSystem>();
        wind = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float volume = (float) dust.particleCount / dust.maxParticles;
        volume = volume * (max_vol - min_vol) + min_vol;
        wind.volume = volume;
    }
}