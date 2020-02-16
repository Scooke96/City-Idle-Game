using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Control : MonoBehaviour
{
    public float increase, shop1Increase;

    public float requirement, shop1Requirement;

    public static int shop1Amount;

    public int shop1Workers, shop1MaxWorkers;

    void Start()
    {
        StartCoroutine(Generate());
    }
    void Update()
    {
        increase = shop1Increase * shop1Workers;
        requirement = shop1Requirement * shop1Amount;
    }

    IEnumerator Generate()
    {
        if (Resources_Control.electricity >= requirement && shop1Workers > 0)
        {
            Resources_Control.money += increase;
            Resources_Control.electricity -= requirement;
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
