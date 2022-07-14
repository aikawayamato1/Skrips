using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerUnlock1 : MonoBehaviour
{
    public BookMenu BM;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            BM.changeBoolean(1);
        }
    }
}
