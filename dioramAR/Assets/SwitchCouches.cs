using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SwitchCouches : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject btn;
    public List<GameObject> couches;
    public List<GameObject> text;
    private int index = 0;

    // Use this for initialization
    void Start()
    {
        btn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        couches[index].SetActive(true);
        text[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        couches[index].SetActive(false);
        text[index].SetActive(false);

        index++;

        if (index > 2)
        {
            index = 0;
        }

        couches[index].SetActive(true);
        text[index].SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
    }
}
