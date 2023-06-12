using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Management;

public class NavigationController : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnExitButtonClick()
    {
        XRGeneralSettings.Instance.Manager.StopSubsystems();
        XRGeneralSettings.Instance.Manager.DeinitializeLoader();
        Application.Quit();
    }


}
