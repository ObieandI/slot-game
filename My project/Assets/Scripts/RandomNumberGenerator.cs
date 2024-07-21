using UnityEngine;
using TMPro;
using System.Collections;

public class RandomNumberGenerator : MonoBehaviour
{
    public TMP_Text numberDisplay; // Reference to the TextMeshPro element
    public float interval = 0.5f; // Time interval between number generation
    private bool isGenerating = false;
    private int multiplier = 1;

    public void StartGenerating()
    {
        if (!isGenerating)
        {
            isGenerating = true;
            StartCoroutine(GenerateNumbers());
        }
    }

    public void StopGenerating()
    {
        if (isGenerating)
        {
            isGenerating = false;
            StopCoroutine(GenerateNumbers());
        }
    }

    public void SetMultiplier1x()
    {
        multiplier = 1;
    }

    public void SetMultiplier2x()
    {
        multiplier = 2;
    }

    public void SetMultiplier3x()
    {
        multiplier = 3;
    }

    public void SetMultiplier4x()
    {
        multiplier = 4;
    }

    IEnumerator GenerateNumbers()
    {
        while (isGenerating)
        {
            int randomNumber = Random.Range(0, 101) * multiplier; // Generate number from 0 to 100
            numberDisplay.text = randomNumber.ToString();
            yield return new WaitForSeconds(interval);
        }
    }
}
