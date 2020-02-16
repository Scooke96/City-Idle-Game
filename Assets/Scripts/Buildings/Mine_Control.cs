using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine_Control : MonoBehaviour
{
    public float increase, mine1Increase;

    public float requirement, mine1requirement;

    public static int mine1Amount, mine1MaxWorkers;

    public int mine1Workers;

    void Start()
    {
        StartCoroutine(Generate());
    }
    void Update()
    {
        increase = mine1Increase * mine1Workers;
    }

    IEnumerator Generate()
    {
        Resources_Control.minerals += increase;
        yield return new WaitForSeconds(1);
        StartCoroutine(Generate());
    }
}
