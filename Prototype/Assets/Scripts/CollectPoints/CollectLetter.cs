using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectLetter : MonoBehaviour
{
        private void OnTriggerEnter(Collider other)
    {
        if(other.name=="Player")
        {
            other.GetComponent<PlayerCollectLetter>().points++;
            Destroy(gameObject);
        }
    }
}
