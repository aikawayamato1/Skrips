using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateCon : MonoBehaviour
{
    bool Open=false;
    
    public void ChangeOpen()
    {
        Open = true;
    }
    public bool Gates()
    {
        return Open;
    }
}
