using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectLetter : MonoBehaviour
{
    public int points = 0;
    

    private void OnGUI()
    {
        GUI.Label(new Rect(100, 40, 200, 40), "Lettres: " + points + "/10");
    }
}
