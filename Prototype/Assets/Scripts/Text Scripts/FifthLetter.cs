using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FifthLetter : MonoBehaviour
{
    public GameObject FifthLetterText;

    public void Start()
    {
        FifthLetterText.SetActive(false);
    }

    public void OnMouseOver()
    {
        FifthLetterText.SetActive(true);
    }

    public void OnMouseExit()
    {
        FifthLetterText.SetActive(false);
    }
}
