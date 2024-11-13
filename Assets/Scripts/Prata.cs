using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Prata : MonoBehaviour
{
    public TextMeshProUGUI LineUI;

    private Canvas dialogueCanvas;

    private Queue<string> upcominglines;
    // Start is called before the first frame update
    void Start()
    {
        dialogueCanvas = LineUI.canvas;
        dialogueCanvas.enabled = false;
    }

    public void StartTalking(TextAsset manus)
    {
        var lines = manus.text.Split('\n');
        upcominglines = new Queue<string>(lines);
        LineUI.text = upcominglines.Dequeue();
        dialogueCanvas.enabled = true;
    }

    public void ProgressDialouge(InputAction.CallbackContext context)
    {
        LineUI.text = upcominglines.Dequeue(); 
    }

    // Update is called once per frame
    void Update()
    {

    }
}


