using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseGetItem : MonoBehaviour
{
    Vector3 mousePos;
    public GameObject[] gameobjects;
    public ItemList il;
    int index=0;
    // Start is called before the first frame update
    void Start()
    {
        gameobjects = new GameObject[10];
        il = GameObject.Find("ItemList").GetComponent<ItemList>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            mousePos = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit != null)
            {
                if(hit.transform.gameObject.tag=="Item")
                {
                    if(hit.transform.gameObject.name=="Circle")
                    {
                        gameobjects[index] = il.gameobjects[0];
                        index++;
                    }
                    
                    
                    Destroy(hit.transform.gameObject);
                }

            }

        }
    }
}
