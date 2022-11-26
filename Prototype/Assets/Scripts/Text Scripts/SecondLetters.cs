using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLetters : MonoBehaviour
{
    public GameObject SecondLetterText;

    public void Start()
    {
        SecondLetterText.SetActive(false);
    }

    public void OnMouseOver()
    {
        SecondLetterText.SetActive(true);
    }

    public void OnMouseExit()
    {
        SecondLetterText.SetActive(false);
    }
}
