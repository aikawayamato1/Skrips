using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timeset = 2000f;
    // Update is called once per frame
    void Update()
    {
        timeset -= Time.deltaTime;
    }
}
