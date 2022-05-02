using UnityEngine;

public class SignupAndLoginUIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _loginButton, _signupButton, _switchToLoginButton, _swtichToSignupButton, _userName;


    public void OnSwitchLoginAndSignClicked(int index)
    {
        switch(index)
        {
            case 0:
                SwitchToLogin();
                break;
            case 1:
                SwitchToSignup();
                break;
        }
    }

    private void SwitchToLogin()
    {
        _userName.SetActive(false);
        _signupButton.SetActive(false);
        _switchToLoginButton.SetActive(false);
        _loginButton.SetActive(true);
        _swtichToSignupButton.SetActive(true);
    }

    private void SwitchToSignup()
    {
        _userName.SetActive(true);
        _signupButton.SetActive(true);
        _switchToLoginButton.SetActive(true);
        _loginButton.SetActive(false);
        _swtichToSignupButton.SetActive(false);
    }

}
