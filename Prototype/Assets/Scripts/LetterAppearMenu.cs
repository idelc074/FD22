using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterAppearMenu : MonoBehaviour
{
    public GameObject LetterMenuText;
    public GameObject CollectableObject;

    public void Start()
    {
        LetterMenuText.SetActive(false);
    }

    public void Update()
    {
        if(CollectableObject.activeInHierarchy==false)
        {
            LetterMenuText.SetActive(true);
        }
    }
}
