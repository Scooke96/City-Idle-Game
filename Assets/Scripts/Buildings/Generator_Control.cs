using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_Control : MonoBehaviour
{
    public float increase, gen1Increase;

    public float requirement, gen1Requirement;

    public static int gen1Amount;

    public int gen1Workers, gen1MaxWorkers;

    void Start()
    {
        StartCoroutine(Generate());
    }
    void Update()
    {
        increase = (gen1Increase * gen1Workers);
        requirement = (gen1Requirement * gen1Amount);
        
    }

    IEnumerator Generate()
    {
        if (Resources_Control.minerals >= requirement && gen1Workers > 0)
        {
            Resources_Control.electricity += increase;
            Resources_Control.minerals -= requirement;
            yield return new WaitForSeconds(1);
            StartCoroutine(Generate());
        }
        else
        {
            yield return new WaitForSeconds(1);
            StartCoroutine(Generate());
        }
        
    }
}
