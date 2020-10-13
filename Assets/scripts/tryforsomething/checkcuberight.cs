using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkcuberight : MonoBehaviour
{
    public bool startcheck;

    GameObject obje;
    GameObject[] grandparents;


    private void Start()
    {
        grandparents = GameObject.FindGameObjectsWithTag("level");
    }
    private void Update()
    {
        if (startcheck && !(obje == null)) { obje.GetComponent<forcube>().connected = true; }
    }
    private void OnTriggerEnter(Collider other)
    {
        obje = other.gameObject;
        
    }
    private void OnTriggerExit(Collider exit)
    {
        Debug.Log("exit");
        int x = grandparents.Length;
        for (int i = 0; i < x; i++)
        {
            grandparents[i].GetComponent<forcube>().somedie = true;
        }
    }





}
