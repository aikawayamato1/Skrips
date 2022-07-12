using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closenote : MonoBehaviour
{
    public GameObject go;
    public void Close()
    {
        go.SetActive(false);
    }
}
