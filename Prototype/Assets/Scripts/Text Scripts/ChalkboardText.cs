using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkboardText : MonoBehaviour
{
    public GameObject ChalkboardEx;

    public void Start()
    {
        ChalkboardEx.SetActive(false);
    }

    public void OnMouseOver()
    {
        ChalkboardEx.SetActive(true);
    }

    public void OnMouseExit()
    {
        ChalkboardEx.SetActive(false);
    }
}
