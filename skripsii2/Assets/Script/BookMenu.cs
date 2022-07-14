using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookMenu : MonoBehaviour
{
    public Button button;
    
    private const int Size = 10;
    public bool[] lockedpages = new bool[Size];
    
    public int indexsize=4;
    public Text[] Paragraph=new Text[Size];
    int index=0;
    public void Next()
    {
        if(lockedpages[index]==false)
        {
            if(index<indexsize)
            {
                Paragraph[index].gameObject.SetActive(false);
                index++;

                Paragraph[index].gameObject.SetActive(true);
            }
            
        }
        

    }
    public void Prev()
    {
        if(index>0)
        {
            Paragraph[index].gameObject.SetActive(false);
            index--;

            Paragraph[index].gameObject.SetActive(true);
        }
            
        
    }
    public int getIndex()
    {
        return index;
    }
    public void changeBoolean(int idx)
    {
        lockedpages[idx]= false;
        Debug.Log("Unlocked");
    }
    public void open()
    {
        gameObject.SetActive(true);
        button.enabled = false;
    }
    public void Close()
    {
        gameObject.SetActive(false);
        button.enabled = true;
    }
}
