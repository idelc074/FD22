using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadOnInteract : MonoBehaviour, IInteractable
{
    public float MaxRange { get { return maxRange; } }

    private const float maxRange= 100f;

    public void OnStartHover()
    {
        Debug.Log($"Ready to destroy {gameObject.name}");
    }
    
    public void OnInteract()
    {
        Destroy(gameObject);
    }

    public void OnEndHover()
    {
        Debug.Log($"We have lost the letter"); 
    }
}
