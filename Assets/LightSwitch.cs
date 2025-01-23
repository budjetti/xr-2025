using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light light;

    void Update()
    {
        if(Input.GetKeyDown("tab")){
            light.color = Color.red;
        }
    }
}
