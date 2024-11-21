using UnityEngine;
using TMPro;

// This interface is used for any interactivity behavior to inherit (base interface)
// Used to invoke specific behaviors
interface IInteractable {
    public void Interact();
}

public class Interactor : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform InteractorSource; 
    public float InteractRange; 
    public TMP_Text InteractMessage; 

    private void Start() { 
        // Hide message at start by default
        InteractMessage.gameObject.SetActive(false); 
    }

    // Update is called once per frame
    private void Update() {
        Ray ray = new Ray(InteractorSource.position, InteractorSource.forward);
        
        // Cast ray and check if we hit something within the interaction range
        if (Physics.Raycast(ray, out RaycastHit hitInfo, InteractRange)) {
            // Check if the object hit by the ray is interactable
            if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactComponent)) {
                // Show the interaction message
                InteractMessage.gameObject.SetActive(true); 
                InteractMessage.text = "Press e to interact";
                
                // If player presses e, interact with the object
                if (Input.GetKeyDown(KeyCode.E)) { 
                    interactComponent.Interact();
                }
            }
            else {
                // Hide the message if the object is not interactable
                InteractMessage.gameObject.SetActive(false);

            }
        }
        else {
            // Hide the message when ray does not hit anything or the interaction range is exceeded
            InteractMessage.gameObject.SetActive(false);

        }
    }
}
