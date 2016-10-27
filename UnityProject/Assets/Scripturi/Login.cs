using UnityEngine;
using System.Collections;

public class Login : MonoBehaviour {

    public string inputUserName;
    public string inputPassword;
    string LoginURL = "http://coadademaimuta.com/eduard_udriste_licenta/Login.php";
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.L)) StartCoroutine(LoginDB(inputUserName, inputPassword));

	
	}

    IEnumerator LoginDB(string username , string password)
    {
        WWWForm form = new WWWForm();

        form.AddField("usernamePost", username);
        form.AddField("passwordPost", password);

        WWW www = new WWW(LoginURL, form);
        yield return www;
        Debug.Log(www.text);
    }
}
