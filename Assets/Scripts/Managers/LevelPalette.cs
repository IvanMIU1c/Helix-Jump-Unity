using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] 

public class Colors
{
    public Color axisColor;
    public Color ballColor;
    public Color defaultColor;
    public Color trapColor;
    public Color finishColor;

    public Color bgColor;
}

public class LevelPalette : MonoBehaviour
{
    [SerializeField] private Colors[] palette;
    [SerializeField] private Material axisMaterial;
    [SerializeField] private Material ballMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material trapMaterial;
    [SerializeField] private Material finishMaterial;
    [SerializeField] private Image bgImage;

    private void Start()
    {
        int index = Random.Range(0, palette.Length);
        axisMaterial.color = palette[index].axisColor;
        ballMaterial.color = palette[index].ballColor;
        defaultMaterial.color = palette[index].defaultColor;
        trapMaterial.color = palette[index].trapColor;
        finishMaterial.color = palette[index].finishColor;
        bgImage.color = palette[index].bgColor;
    }
}
