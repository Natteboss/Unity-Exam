using System;
using UnityEngine;
using UnityEngine.Events;

public class DialogueStarter : MonoBehaviour
{
    public GameObject dialogueWindow;

    [SerializeField] private UnityEvent startDialogue;
    [SerializeField] private UnityEvent onExit;

    private bool dialogueDone = true;
    [SerializeField] private GameObject dialogueIcon;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ActivateDialogue();

            if (dialogueDone)
            {
                dialogueDone = false;
                startDialogue?.Invoke();
                Debug.Log("Activated dialogue");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DisableDialogue();
        }
    }

    public void ActivateDialogue()
    {
        dialogueWindow.SetActive(true);
        dialogueIcon.SetActive(false);
    }

    public void DisableDialogue()
    {
        dialogueWindow.SetActive(false);
        dialogueIcon.SetActive(true);
        onExit?.Invoke();
        dialogueDone = true;
    }
}
