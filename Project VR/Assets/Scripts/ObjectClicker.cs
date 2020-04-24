using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    //public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { 
        
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;
                if(bc != null)
                {
                    if (bc.transform.GetChild(0).gameObject.activeSelf)
                    {
                        bc.transform.GetChild(0).gameObject.SetActive(false);
                    }
                    else
                    {
                        bc.transform.GetChild(0).gameObject.SetActive(true);
                    }
                    
                }
            }
        }
    }
}
