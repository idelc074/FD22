using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLetter : MonoBehaviour
{
    public GameObject FirstLetterText;

    public void Start()
    {
        FirstLetterText.SetActive(false);
    }

    public void OnMouseOver()
    {
        FirstLetterText.SetActive(true);
    }

    public void OnMouseExit()
    {
        FirstLetterText.SetActive(false);
    }
}
