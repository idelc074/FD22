using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllLettersActive : MonoBehaviour
{
    public GameObject AllLetters;

    public GameObject LetterOne;
    public GameObject LetterTwo;
    public GameObject LetterThree;
    public GameObject LetterFour;
    public GameObject LetterFive;
    public GameObject LetterSix;
    public GameObject LetterSeven;
    public GameObject LetterEight;
    public GameObject LetterNine;
    public GameObject LetterTen;

    public GameObject ClosedDoor;
    public GameObject OpenDoor;
    


    public void Start()
    {
        AllLetters.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        if(LetterOne.activeInHierarchy==false && LetterTwo.activeInHierarchy == false && LetterThree.activeInHierarchy == false && LetterFour.activeInHierarchy == false && LetterFive.activeInHierarchy == false
            && LetterSix.activeInHierarchy == false && LetterSeven.activeInHierarchy == false && LetterEight.activeInHierarchy == false && LetterNine.activeInHierarchy == false && LetterTen.activeInHierarchy == false)
        {
            AllLetters.SetActive(true);
        }

        if (AllLetters.activeInHierarchy == true)
        {
            ClosedDoor.SetActive(false);
            OpenDoor.SetActive(true);
        }
    }
}
