using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelconroller : MonoBehaviour
{
    public GameObject[] scenes;
    GameObject currnt;
    int i=0;
    public panelcontrols panel;
    private void Start()
    {
        currnt = Instantiate(scenes[i],Vector3.zero,Quaternion.identity);
        i++;
    }
    public void next()
    {
        Destroy(currnt);
        if (i == scenes.Length) { panel.gameover(); }
        else 
        {
            StartCoroutine(SpawnNextStage());
        }
       
      
    }
    private IEnumerator SpawnNextStage()
    {
        yield return new WaitForSeconds(1f);//bir sn sonra sonraki scenei çağırır
       
            currnt = Instantiate(scenes[i], Vector3.zero, Quaternion.identity);
            i++;
       
        

    }



}
