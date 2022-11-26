using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdLetter : MonoBehaviour
{
    public GameObject ThirdLetterText;

    public void Start()
    {
        ThirdLetterText.SetActive(false);
    }

    public void OnMouseOver()
    {
        ThirdLetterText.SetActive(true);
    }

    public void OnMouseExit()
    {
        ThirdLetterText.SetActive(false);
    }
}
