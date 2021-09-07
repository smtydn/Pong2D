using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    private static HUD _instance;

    public RectTransform quitMenu;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(_instance);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            quitMenu.gameObject.SetActive(!quitMenu.gameObject.activeSelf);
        }
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }
}
