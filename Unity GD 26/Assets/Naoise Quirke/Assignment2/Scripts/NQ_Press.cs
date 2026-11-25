using System;
using Unity.AppUI.UI;
using UnityEngine;
using UnityEngine.UI;

public class Press : MonoBehaviour
{
    int pressed = 0;
    public Color wantedColor;
    public UnityEngine.UI.Button button;
    public void Clicked()
    {
        print("Did a thing");
        pressed++;
        print("Times button pressed: " + pressed);

        ColorBlock cb = button.colors;
        cb.normalColor = wantedColor;
        cb.highlightedColor = wantedColor;
        cb.pressedColor = wantedColor;
        button.colors = cb;
    }
}
