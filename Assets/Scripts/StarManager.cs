using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarManager : MonoBehaviour
{

    [SerializeField] int numberOfStars = 100;
    Text txt_Stars;

    // Start is called before the first frame update
    void Start()
    {
        txt_Stars = GetComponent<Text>();
        UpdateStarsText();
    }

    private void UpdateStarsText()
    {
        txt_Stars.text = numberOfStars.ToString();
    }

    public int GetCurrentNumberOfStars()
    {
        return numberOfStars;
    }

    // Update is called once per frame
    public void AddStars(int amountOfStars)
    {
        numberOfStars += amountOfStars;
        UpdateStarsText();
    }

    public void SpendStars (int amountOfStars)
    {
        if (numberOfStars >= amountOfStars)
        {
            numberOfStars -= amountOfStars;
            UpdateStarsText();
        }

    }
}
