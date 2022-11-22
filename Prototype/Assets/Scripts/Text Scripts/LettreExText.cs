using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LettreExText : MonoBehaviour
{
    public GameObject LettreEx;

    public void Start()
    {
        LettreEx.SetActive(false);
    }
    
    public void OnMouseOver()
    {
        LettreEx.SetActive(true);
    }
    
    public void OnMouseExit()
    {
        LettreEx.SetActive(false);
    }
}
