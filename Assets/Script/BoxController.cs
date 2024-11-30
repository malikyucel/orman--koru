using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class BoxController : MonoBehaviour
{
    private int count_;
    private float horizontalInput;
    public float speed;
    public bool BoxCont = true;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BoxCont)
        {
            // box right left movement
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.forward * horizontalInput * speed * Time.deltaTime);
        }

        // right left border
        if (transform.position.z < -17)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -17);
        }
        if (transform.position.z > 17)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 17);
        }
        


    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        {
            count_ += 1;
            score.text = "Count: " + count_;
            Destroy(other.gameObject);
        }
        
    }
}
