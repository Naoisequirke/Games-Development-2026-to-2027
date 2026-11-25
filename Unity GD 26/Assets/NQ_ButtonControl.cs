using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NQ_ButtonControl : MonoBehaviour
{

    UnityEngine.UI.Button button;

    Text text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       button = GetComponent<UnityEngine.UI.Button>();
        if (button != null) { print("found"); }

        text = GetComponentInChildren<TMP_Text>();
        if (text != null) { print("found"); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
