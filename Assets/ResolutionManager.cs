using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionManager : MonoBehaviour
{
    [SerializeField] Slider heightRes;
    [SerializeField] Slider widthRes;
    [SerializeField] Slider fullScreenSlider;

    private bool fullscreen;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(720, 480, false);
    }

    // Update is called once per frame
    void Update()
    {
        if (fullScreenSlider.value > 0.5f)
        {
            fullscreen = true;
        }
        else fullscreen = false;
    }

    public void ChangeResolution()
    {
        Screen.SetResolution((int)widthRes.value, (int)heightRes.value, fullscreen);
    }
}
