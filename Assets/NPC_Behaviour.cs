using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Behaviour : MonoBehaviour
{
    
    public GameObject FishDialogue;
    public bool DialogueOver = false;
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
