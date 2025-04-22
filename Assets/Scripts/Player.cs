using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;

//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;
    float floatingInput;

    Vector3 moveDirection;

    Rigidbody rb;
    public GameObject FishUI;
    public GameObject InteractIcon;
    private bool isTalking;

    private bool dialogueOver;
    public GameObject enemyAI;
    AIBehavior enemyAI_script;
    NPC_Behaviour interactibleNPC;

    private void Start()
    {
        {
            rb = GetComponent<Rigidbody>();
            rb.freezeRotation = true;
            enemyAI_script = enemyAI.GetComponent<AIBehavior>();
        }
    }

    void Update()
    {
        MyInput();
        SpeedControl();

        if (Input.GetKeyDown(KeyCode.T))
        {
            NPCInteract();
        }
    }

    static public bool dialogue = false;

    private void FixedUpdate()
    {
        if (!dialogue)
        {
            MovePlayer();
        }
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        floatingInput = Input.GetAxisRaw("Float");
    }

    private void MovePlayer()
    {
        moveDirection = (orientation.forward * verticalInput * Time.deltaTime) + (orientation.right * horizontalInput * Time.deltaTime) + (orientation.up * floatingInput * Time.deltaTime);

        rb.AddForce(moveDirection.normalized * moveSpeed * 5f, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    void NPCInteract()
    {
        if (!isTalking && !interactibleNPC.DialogueOver)
        {
            Debug.Log("Anger speaks.");
            interactibleNPC.FishDialogue.SetActive(true);
            //FishUI.SetActive(true);
            InteractIcon.SetActive(false);
            isTalking = true;
        } 
        else
        {
            isTalking = false;
            FishUI.SetActive(false);
            //dialogueOver = true;
            interactibleNPC.DialogueOver = true;
            //interactibleNPC.enabled = false;
            //enemyAI_script.enabled = true;
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other != null && other.tag == "NPC")
        {
            NPC_Behaviour npc = other.GetComponent<NPC_Behaviour>();
            interactibleNPC = npc;
            if (npc.DialogueOver == false && isTalking == false)
            {
                InteractIcon.SetActive(true);
            }   
            else 
            {
                InteractIcon.SetActive(false);
            }
            //npc.FishDialogue.SetActive(true);
        } 
    }
}
