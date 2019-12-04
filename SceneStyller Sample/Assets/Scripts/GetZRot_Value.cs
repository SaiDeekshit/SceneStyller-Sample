using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetZRot_Value : MonoBehaviour
{
    public Slider Slider_TOD;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ang;
        ang = (Slider_TOD.value) * 180 - 90f;
        this.transform.eulerAngles = new Vector3(0,0,ang);
        
    }
  
}
