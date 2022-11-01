using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    private bool flipScene = false;
    [SerializeField] private TMP_InputField playerNameText;

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
