using UnityEngine;
using TMPro;
public class ShowTextOnKeyPress : MonoBehaviour
{
    public TMP_Text displayText;

    void Start()
    {
        if (displayText != null)
        {
            displayText.text = "";
            displayText.fontSize = 50;
            displayText.alignment = TextAlignmentOptions.Center;
        }
    }

    void Update()
    {
        if (displayText == null) return;

        if (Input.GetKey(KeyCode.Q))
            displayText.text = "WARMING";
        else if (Input.GetKey(KeyCode.W))
            displayText.text = "SIMPLE MOVE";
        else if (Input.GetKey(KeyCode.E))
            displayText.text = "ADVANCED MOVEMENT";
        else if (Input.GetKey(KeyCode.R))
            displayText.text = "FINAL MOVE";
        else
            displayText.text = "";
    }
}
