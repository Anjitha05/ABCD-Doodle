using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTheTrace : MonoBehaviour
{
    public Color correctColor = Color.green, wrongColor = Color.red;
    public DrawLine drawLine;
    public ChangeAlphabet changeAlphabet;
    public Material material;
    bool wentWrong = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(worldPos.x, worldPos.y);
            Collider2D hit = Physics2D.OverlapPoint(mousePos2D);
            if (hit != null)
            {
                Debug.Log("Correct position: " + hit.name);
                material.color = correctColor;
                material.EnableKeyword("_EMISSION");
                material.SetColor("_EmissionColor", correctColor);
            }
            else
            {
                Debug.Log("Going Wrong");
                material.color = wrongColor;
                material.EnableKeyword("_EMISSION");
                material.SetColor("_EmissionColor", wrongColor);
                wentWrong = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (wentWrong == false)
            {
                Debug.Log("Good Work. Lets go to next Alphabet");
                changeAlphabet.NextAlphabet();
                drawLine.ClearLine();
            }
            else
            {
                Debug.Log(" Lets try Again");
                drawLine.ClearLine();
                wentWrong = false;
            }
        }

    }
}
