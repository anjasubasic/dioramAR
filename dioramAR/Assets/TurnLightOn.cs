using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TurnLightOn : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject btn;
    public List<GameObject> lights;
    private int index = 0;

    // Use this for initialization
    void Start()
    {
        btn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        lights[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        lights[index].SetActive(false);

        index++;

        if (index > 1)
        {
            index = 0;
        }

        lights[index].SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
    }
}

