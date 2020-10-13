using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getchildcenter : MonoBehaviour
{
    private GameObject[] Child;
    public  forcube iscenter;
    private forcube cubes;
    int x = 0;
    public int a;
    void Start()
    {
        int count = gameObject.transform.childCount;
    
        for (int i = 0; i < count; i++)
        {
            cubes = GetComponentInChildren<forcube>();
                if (cubes.center)
                {
                    iscenter = cubes;
                iscenter.deneme = true;
                }
            }
            
          
            
        }



    }



