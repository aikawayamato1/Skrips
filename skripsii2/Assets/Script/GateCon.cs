using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateCon : MonoBehaviour
{
    bool Open=false;
    public GameManager gm;
    public void ChangeOpen()
    {
        Open = true;
        Debug.Log("Open");
    }
    public void OpenGateTest()
    {
        gm.Winning();
    }
    public bool Gates()
    {
        return Open;
    }
}
