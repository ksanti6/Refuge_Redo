using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Spin : MonoBehaviour
{
    public GameObject rot_obj;
    public float rot_speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rot_obj.transform.Rotate(0f, rot_speed * Time.deltaTime, 0f);
    }
}
