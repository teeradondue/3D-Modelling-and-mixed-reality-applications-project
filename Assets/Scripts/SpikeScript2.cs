using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript2 : MonoBehaviour
{

    private IEnumerator coroutine;
    float attack = 300f;
    float down = 3.5f;
    int num = 10000;

    private void Start()
    {
        coroutine = PlayAnim();
        StartCoroutine(coroutine);

    }

    private IEnumerator PlayAnim()
    {
        while (true)
        {
            Spikeup();
            yield return new WaitForSeconds(2);
            Spikedown();
            yield return new WaitForSeconds(9);
        }

    }

    void Spikeup()
    {
        transform.localScale = new Vector3(120, 120, attack);

    }

    void Spikedown()
    {
        transform.localScale = new Vector3(120, 120, down);

    }
}
