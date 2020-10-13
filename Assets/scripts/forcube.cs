using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcube : MonoBehaviour
{
    int score,x=0;

    public bool center,connected;
    public bool somedie,deneme;

    public panelcontrols cont;

    public GameObject particle,aa;

    public Material player;
    void Start()
    {
        if (center)
        {
            gameObject.GetComponent<MeshRenderer>().material = player;
           
        }
        cont = GameObject.Find("Canvas").GetComponent<panelcontrols>();
        cont.score = 0;
    }

    public void destroycubes()
    {
        if (!center)
        {// eğer merkez değilse yok et merkezse game over
            cont.score += 10;
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
        else if (center)
        {
            cont.gameover();
            Time.timeScale = 0;
          
        }
        
    }

    /*
    private void Update()
    {
        if (somedie || connected) { checkcon();somedie = false; Debug.Log("somedie"); }
       
    }
    void checkcon()
    {
        Debug.Log("checkson");
        if (center || connected)
        {
            Debug.Log("startchec");
            for (int x = 0; x < 4; x++) {
                  GameObject Child;
                  Child = transform.GetChild((int)x).gameObject;
                  Child.GetComponent<checkcuberight>().startcheck = true;
              }
              
        }


    }

    */

}
