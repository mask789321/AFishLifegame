using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    public GameObject FishUI;
    public int NumberOfDialogueLines;
    public void Start()
    {
        FishUI.SetActive(false);
    }
    public void Interact()
    {
        Debug.Log("Anger speaks.");
        FishUI.SetActive(true);
        StartCoroutine(SetFalse());
        
    }

    IEnumerator SetFalse()
    {
        yield return new WaitForSeconds(3);
        FishUI.SetActive(false);
    }



}
