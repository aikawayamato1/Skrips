using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggergate : MonoBehaviour
{
    bool canOpen=false;
    public GateCon GC;
    public bool a;
    public bool b;
    public bool c;
    public bool d;
    public bool rusted;
    

    private void OnTriggerEnter2D(Collider2D col)
    {
       if(col.gameObject.tag=="Player")
        {
            Debug.Log("In");
            canOpen =true;
        }
    }
    
    public void Opengate()
    {
        if(canOpen==true)
        {
            if (a==true)
            {
                Debug.Log("Open");
                GC.ChangeOpen();
            }
            if (b == true)
            {
                Debug.Log("Lost");
            }
            if (c == true)
            {
                Debug.Log("Lost");
            }
            if (d == true)
            {
                Debug.Log("Lost");
            }
            if(rusted==true)
            {

                Destroy(gameObject);
                
            }
        }
    }
}
