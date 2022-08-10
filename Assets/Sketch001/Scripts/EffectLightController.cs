using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectLightController : MonoBehaviour
{
    public float min_intensity;
    public float max_intensity;
    public float frequency;

    void Update()
    {
        Light light = gameObject.GetComponent(typeof(Light)) as Light;
        Debug.Log(light.intensity);
        light.intensity = min_intensity + ((max_intensity - min_intensity) * ((Mathf.Sin(frequency * Time.time) / 2) + 0.5f));

    }
}
