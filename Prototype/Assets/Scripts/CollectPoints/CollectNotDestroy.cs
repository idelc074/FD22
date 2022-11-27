using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectNotDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<PlayerCollectLetter>().points++;
            (gameObject).SetActive(false);
        }
    }
}
