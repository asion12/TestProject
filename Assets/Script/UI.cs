using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    int a = 1;
    TextMeshProUGUI textMeshPro;
   
    [Range(0f, 100f)]
   public int tmpFontsize;
    [TextArea(9,10)]
    public string text;
    [ContextMenuItem("Chang", "Oh")]
    [ContextMenuItem("Reset", "Haeul")]
    public string context;
    private void Start()
    {
       textMeshPro = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            a *= 2;
        }    
        textMeshPro.text= $"���� �� :{a}" ;


        textMeshPro.fontSize = tmpFontsize;
    }
    void Oh()
    {
        context = "��â������";
        text = context;
    }
    void Haeul()
    {
        context = "";
        text = context; 
    }

}
