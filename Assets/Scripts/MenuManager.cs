using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerNameText;
    private bool flipScene = false;

    private void Start() 
    {
        
    }

    private void Update() 
    {
       playerNameText.onSubmit.AddListener(delegate {ValueChanged();});

       if (flipScene)
       {
            SceneManager.LoadScene(1);
       }
    }

    private void ValueChanged()
    {
        DataManager.Instance.PlayerName = playerNameText.text;
        flipScene = true;
    }
}
