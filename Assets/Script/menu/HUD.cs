using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text point;

    


    void Update()
    {
        point.text = DataLevel.cheese + "";
    }
}
