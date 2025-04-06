using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AngerDialogue : MonoBehaviour
{
    public GameObject dialogue_template;
    public GameObject canvas;
    bool player_detection = false;

    void Update()
    {
        if (player_detection && Input.GetKeyDown(KeyCode.F) && !Player.dialogue)
        {
            Player.dialogue = true;
            NewDialogue("I'm going to eat you!!"); //prototype NOT Final dialogue
        }
    }

    void NewDialogue(string text)
    {
        GameObject template_clone = Instantiate(dialogue_template, dialogue_template.transform);
        template_clone.transform.SetParent(canvas.transform);
        template_clone.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = text;
        dialogue_template.GetComponent<TextMeshProUGUI>().text = text;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name=="PlayerBody")
        {
            player_detection = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
    }
}
