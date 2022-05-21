using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biscuit_Trigger : MonoBehaviour
{
    public GameObject Next_Biscuit;
    void Start()
    {
        Next_Biscuit.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
       
        //Next_Biscuit.SetActive(true);
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Touch");
            Next_Biscuit.SetActive(true);
        }
        
    }
}
