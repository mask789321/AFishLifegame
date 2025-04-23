using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC_Behaviour : MonoBehaviour
{
    
    public GameObject FishDialogue;
    public bool DialogueOver = false;
    public int NumberOfDialogueLines;
    public GameObject Dialogue1;
    public GameObject Dialogue2;

    // Start is called before the first frame update
    void Start()
    {
        FishDialogue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
