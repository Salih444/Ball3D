using UnityEngine;

public class player : MonoBehaviour

{
    public Rigidbody rb;
    private Touch touch;
    public int speedModifier;
    public void Start(){
        rb= GetComponent<Rigidbody>();
    }

    public void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)

                rb.velocity= new Vector3( touch.deltaPosition.x * speedModifier * Time.deltaTime,
                transform.position.y,
               touch.deltaPosition.y * speedModifier * Time.deltaTime);
        }
    }
}