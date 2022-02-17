using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Principal : MonoBehaviour
{
    public Text Text;

    public void NewJoke(){
        ClassJoke joke = API.GetNewJoke();
        Text.text = joke.value;
    }
}
