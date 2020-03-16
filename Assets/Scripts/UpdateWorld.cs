using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateWorld : MonoBehaviour
{
    public Text state;


    void LateUpdate()
    {
        Dictionary<string, int> worldStates = GWorld.Instance.GetWorld().GetStates();
        state.text = "";

        foreach(KeyValuePair<string, int> s in worldStates)
        {
            state.text += s.Key + ", " + s.Value + "\n"; 
        }
    }
}
