using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAlphabet : MonoBehaviour
{

    public GameObject[] alphabetSprites;
    public void NextAlphabet()
    {
        for (int i = 0; i < alphabetSprites.Length - 1; i++)
        {
            if (alphabetSprites[i].activeSelf)
            {
                Debug.Log("This is working");
                alphabetSprites[i].SetActive(false);
                if (i < alphabetSprites.Length)
                {
                    alphabetSprites[i + 1].SetActive(true);
                    Debug.Log("this is working");
                    break;
                }
                else
                {
                    alphabetSprites[0].SetActive(true);
                    break;
                }
            }

        }
    }
}
