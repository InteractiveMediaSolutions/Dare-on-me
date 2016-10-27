using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DataInserter : MonoBehaviour {

    public Text userWelcome;
    public Canvas DupaLogin;
    public Canvas LoginAndRegistration;
    string inputUserName;
    string inputPassword;
    string inputEmail;
    string LoginURL = "http://coadademaimuta.com/eduard_udriste_licenta/Login.php";
    string CreateUserURL = "http://coadademaimuta.com/eduard_udriste_licenta/insertuser.php";
    // Use this for initialization
    void Start () {
        DupaLogin.enabled = false;
        
	
	}

    // Update is called once per frame
    void Update()
    {
    }

    public void CreateUser (string username , string password, string email)
    {

        WWWForm form = new WWWForm();

        form.AddField("usernamePost",username);
        form.AddField("passwordPost", password);
        form.AddField("emailPost", email);

        WWW www = new WWW(CreateUserURL,form);

     
    }


    IEnumerator LoginDB(string username, string password)
    {
        WWWForm form = new WWWForm();

        form.AddField("usernamePost", username);
        form.AddField("passwordPost", password);

        WWW www = new WWW(LoginURL, form);
        yield return www;
        Debug.Log(www.text);
    }

    public void user(InputField newuser)

    {
        inputUserName = newuser.text;
        
    }
    public void password(InputField newpassword)

    {
        inputPassword = newpassword.text;

    }

    public void email(InputField newemail)

    {
        inputEmail = newemail.text;

    }

    public void CreareUser()
    {
        CreateUser(inputUserName, inputPassword, inputEmail);

        Invoke("Logare", 0.5f);

    }

    public void Logare()
    {

        StartCoroutine(LoginDB(inputUserName, inputPassword));
        LoginAndRegistration.enabled = false;
        DupaLogin.enabled = true;
        userWelcome.text = "Welcome," + inputUserName;


    }




}
