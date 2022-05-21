using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wafer_movement1 : MonoBehaviour
{

    public float movement_speed = 0.5f;
    public float min = 1f;
    public float max = 2f;


    private float y;
    private float z;

    // Start is called before the first frame update
    void Start()
    {

        min = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {

        //transform.position = new Vector3(Mathf.PingPong(Time.time * movement_speed, max-min)+min, y, z);
        transform.position = new Vector3(Mathf.PingPong(Time.time * movement_speed, max-min)+min, y, z);

        // source from https://forum.unity.com/threads/moving-an-object-back-and-forth-on-a-single-axis-automatically.235033/
    }
}
