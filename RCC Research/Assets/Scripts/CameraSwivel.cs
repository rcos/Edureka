using UnityEngine;

public class CameraSwivel : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float RotationSpeed = 30; 
    public float RotationAngle = 45; 
    private float CurrentAngle = 0; 
    private int Direction = 1; 

    void Start() {
        // Nothing needed in start
    }

    // Update is called once per frame
    void Update() {
        CurrentAngle += Direction * RotationSpeed * Time.deltaTime; 
        // Condition below creates the swivel motion back and forth
        if (Mathf.Abs(CurrentAngle) > RotationAngle) {
            Direction *= -1; 
        }

        // Transforms the camera object
        this.transform.localRotation = Quaternion.Euler(0, CurrentAngle, 0);
        
    }
}
