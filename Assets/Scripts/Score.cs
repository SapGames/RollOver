using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform Player;
    public TextMeshProUGUI scoretext;

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Player.position.z.ToString("0");
    }
}
