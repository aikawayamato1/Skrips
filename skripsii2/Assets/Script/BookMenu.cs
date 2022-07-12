using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookMenu : MonoBehaviour
{
    private const int Size = 10;
    public int indexsize=4;
    public Text[] Paragraph=new Text[Size];
    int index=0;
    public void Next()
    {
        Paragraph[index].gameObject.SetActive(false);
        index++;
        if(index>indexsize)
        {
            index = 0;
        }
        Paragraph[index].gameObject.SetActive(true);

    }
    public void Prev()
    {
        Paragraph[index].gameObject.SetActive(false);
        index--;
        if (index < 0)
        {
            index = indexsize;
        }
        Paragraph[index].gameObject.SetActive(true);
    }
    public int getIndex()
    {
        return index;
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }
}
