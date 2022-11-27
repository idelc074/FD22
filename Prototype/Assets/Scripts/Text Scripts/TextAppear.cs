using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAppear : MonoBehaviour
{
    public GameObject LetterText;

    public void Start()
    {
        LetterText.SetActive(false);
    }

    public void OnMouseOver()
    {
        LetterText.SetActive(true);
    }

    public void OnMouseExit()
    {
        LetterText.SetActive(false);
    }
}
