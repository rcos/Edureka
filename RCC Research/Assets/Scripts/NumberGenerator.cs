using UnityEngine;

public class NumberGenerator : MonoBehaviour, IInteractable {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Interact() {
        this.gameObject.SetActive(false);
        // Debug.Log(Random.Range(0, 100));
    }

    void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
