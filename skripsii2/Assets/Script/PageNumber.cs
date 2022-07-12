using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageNumber : MonoBehaviour
{
    public BookMenu bm;
    int idx;
    public Text pagenumber;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        idx = bm.getIndex()+1;
        pagenumber.text = idx.ToString();
    }
}
