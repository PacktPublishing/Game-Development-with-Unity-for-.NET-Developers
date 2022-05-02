using System.Text;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using PlayFab;
using PlayFab.ClientModels;

public class AzurePlayFabAccountManager : MonoBehaviour
{
    [SerializeField]
    private InputField _userName, _email, _password;

    [SerializeField]
    private Text _message;

    public void OnSignUpButtonClick()
    {
        var userRequest = new RegisterPlayFabUserRequest
        {
            Username = _userName.text,
            Email = _email.text,
            Password = Encrypt(_password.text)
        };

        PlayFabClientAPI.RegisterPlayFabUser(userRequest, OnRegisterSuccess, OnError);
    }

    public void OnLoginButtonClick()
    {
        var userRequest = new LoginWithEmailAddressRequest
        {
            Email = _email.text,
            Password = Encrypt(_password.text)
        };

        PlayFabClientAPI.LoginWithEmailAddress(userRequest, OnLoginSuccess, OnError);
    }

    public void OnLoginSuccess(LoginResult result)
    {
        _message.text = "login successful!";
        StartGame();
    }

    public void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        _message.text = "created a new account!";

        var displayNameRequest = new UpdateUserTitleDisplayNameRequest
        {
            DisplayName = result.Username
        };

        PlayFabClientAPI.UpdateUserTitleDisplayName(displayNameRequest, OnUpdateDisplayNameSuccess, OnError);
    }

    public void OnUpdateDisplayNameSuccess(UpdateUserTitleDisplayNameResult result)
    {
    }

    public void OnError(PlayFabError error)
    {
        _message.text = error.ErrorMessage;
    }

    private static string Encrypt(string input)
    {
        var md5 = new MD5CryptoServiceProvider();
        var bytes = Encoding.UTF8.GetBytes(input);
        bytes = md5.ComputeHash(bytes);
        return Encoding.UTF8.GetString(bytes);
    }

    private static void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
