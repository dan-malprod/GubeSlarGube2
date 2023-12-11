using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewAll : MonoBehaviour
{
    [SerializeField] Slider heightRes;
    [SerializeField] Slider widthRes;
    [SerializeField] Slider fullScreenSlider;
    [SerializeField] Slider volumeSlider;
    [SerializeField] GameObject back;

    private void Start()
    {
        back.SetActive(false);
    }

    public void NewAllNewAll()
    {
        heightRes.value = Random.Range(800, 2000);
        widthRes.value = Random.Range(480, 2000);
        fullScreenSlider.value = Random.Range(0, 1);
        volumeSlider.value = Random.Range(1, 10);

        back.SetActive(true);
    }
}
