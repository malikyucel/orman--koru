using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plane : MonoBehaviour
{
    private GameManager gameManager;
    public Text heathy;
    public int heathy_ = 10;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        heathy.text = "Heathy: " + heathy_;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Bomb"))
        {

            heathy.text = "Heathy: " + heathy_--;
        }
    }
}
