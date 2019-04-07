using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SwitchBookshelf : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject btn;
    public List<GameObject> bookshelves;
    public List<GameObject> text;
    private int index = 0;

    // Use this for initialization
    void Start()
    {
        btn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        bookshelves[index].SetActive(true);
        text[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        bookshelves[index].SetActive(false);
        text[index].SetActive(false);

        index++;

        if (index > 1)
        {
            index = 0;
        }

        bookshelves[index].SetActive(true);
        text[index].SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
    }
}
