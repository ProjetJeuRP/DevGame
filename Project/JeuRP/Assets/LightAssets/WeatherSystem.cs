using UnityEngine;
using System.Collections;
using System;

public class WeatherSystem : MonoBehaviour 
{
    public int DayNightCycleLength;
    public Light lightSource;

    void Update()
    {
        // SUNLIGHT MNG

        transform.Rotate(360 * Time.deltaTime / DayNightCycleLength, 0, 0);
        if (transform.rotation.eulerAngles.y == 0)
        {
            if (transform.rotation.eulerAngles.x <= 335)
                lightSource.intensity = 1f;
        }
        else // <-- transform.rotation.eulerAngles.y == 180
        {
            if (transform.rotation.eulerAngles.x >= 335)
                lightSource.intensity = 0f;
        }
    }
}
