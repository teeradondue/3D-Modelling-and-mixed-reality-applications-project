using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logmovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float min = 58.55f;
    public float max = 66.48f;
    // Use this for initialization
    void Start()
    {

        max = transform.position.x;
        min = transform.position.x - 9;

    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);

    }
}
