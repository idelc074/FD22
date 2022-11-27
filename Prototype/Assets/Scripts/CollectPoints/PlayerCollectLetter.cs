using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectLetter : MonoBehaviour
{
    public int points = 0;
    

    private void OnGUI()
    {
        GUI.Label(new Rect(1250, 40, 200, 40), "Lettres: " + points + "/10");
    }
}
