using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    [SerializeField] GameObject settings;
    [SerializeField] GameObject tooltip;
    [SerializeField] Button settingsButton;

    private void Start()
    {
        settings.SetActive(false);
        tooltip.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            settings.SetActive(true);
        }
    }

    public void OnOpenTooltip()
    {
        tooltip.SetActive(true);
    }

    public void OnCloseTooltip()
    {
        tooltip.SetActive(false);
    }

    public void CloseSettings()
    {
        settings.SetActive(false);
    }
}
