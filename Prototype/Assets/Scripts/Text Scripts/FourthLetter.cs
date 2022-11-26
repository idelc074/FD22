using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthLetter : MonoBehaviour
{
    public GameObject FourthLetterText;

    public void Start()
    {
        FourthLetterText.SetActive(false);
    }

    public void OnMouseOver()
    {
        FourthLetterText.SetActive(true);
    }

    public void OnMouseExit()
    {
        FourthLetterText.SetActive(false);
    }
}
