using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateFinish : MonoBehaviour
{
    public GameManager gm;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            gm.Winning();
        }
    }
}
