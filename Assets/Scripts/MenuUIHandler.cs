using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;




public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        PersistenceManager.Instance.playerName = nameInput.text;
        SceneManager.LoadScene("main");
    }
}
