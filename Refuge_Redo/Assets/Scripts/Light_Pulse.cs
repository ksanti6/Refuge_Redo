using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Pulse : MonoBehaviour
{
    public Light my_light;
    public float min_intensity = 10f;
    public float max_intensity = 30f;

    public float min_range = 2f;
    public float max_range = 5f;

    private float intensity, range;

    // Start is called before the first frame update
    void Start()
    {
        intensity = max_intensity - min_intensity;
        range = max_range - min_range;
    }

    // Update is called once per frame
    void Update()
    {
        my_light.intensity = min_intensity + Mathf.PingPong(Time.time, intensity);
        my_light.range = min_range + Mathf.PingPong(Time.time, range);
    }
}
