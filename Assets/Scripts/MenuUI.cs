using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUI : MonoBehaviour
{
    public GameObject inputField;
    public void StartNew() {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName() {
        Debug.Log(inputField.GetComponent<TMP_InputField>().text);
        DataManager.Instance.PlayerName = inputField.GetComponent<TMP_InputField>().text;
    }
}
