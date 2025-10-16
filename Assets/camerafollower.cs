using UnityEngine;

public class camerafollower : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset ;
    public Vector3 newPos ;
    public float vll;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset =transform.position- target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
         newPos = target.transform.position+offset;
        transform.position = newPos;
        Rigidbody RB = target.GetComponent<Rigidbody>();
        vll = RB.linearVelocity.magnitude;
        Camera cam = GetComponent<Camera>();
        cam.fieldOfView = 60+ vll;
    }
}
