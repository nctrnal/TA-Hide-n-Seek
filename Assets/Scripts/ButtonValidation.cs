using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonValidation : MonoBehaviour
{
    public Button btnLogin;
    

    //get inputField
    public InputField inputUsername;
    public InputField inputPassword;

    // Start is called before the first frame update
    void Start()
    {
        btnLogin.onClick.AddListener(GetInputOnClickHandler);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetInputOnClickHandler()
    {
        if(inputUsername.text == "tes" && inputPassword.text == "123")
        {
            Debug.Log("berhasil");
            SceneManager.LoadScene("MainScene"); 
        }
        else
        {
            Debug.Log("gagal");
        }
    }

    public void SignUp()
    {
        SceneManager.LoadScene("Sign Up Scene");
    }
}
