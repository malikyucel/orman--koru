using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCont : MonoBehaviour
{
    private Button button;

    GameManager gameManager;
    public int dif;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(StratButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StratButton()
    {
        gameManager.StartGame( dif );

    }
}
