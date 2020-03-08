using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onClickObject : MonoBehaviour
{
    public GameObject panel;
    private int nbClick = 1;

    public void hidePanel()
    {
        if (nbClick % 2 == 1)
        {
            panel.gameObject.SetActive(true);
        }
        else
        {

            panel.gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.Back)) //Changer le bouton (A ajouter sinon OVRInput.GetDown(OVRInput.Button.
        { // if left button pressed...
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                hidePanel();
            }
        }
    }
}
