using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NumberAroundCircle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float radius = 150;
        Vector2 sz = new Vector2(62, 40);

        float angle = 20;
        for (int i = 0; i<9; i++)
        {
            
            Vector3 pos = new Vector3(this.transform.position.x + radius * System.MathF.Sin((angle + 40*i)/180*System.MathF.PI), this.transform.position.y + radius * System.MathF.Cos((angle + 40*i) / 180 * System.MathF.PI), this.transform.position.z);
            CreateNumber(this.transform, pos, sz, 40 + 20*i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateNumber(Transform panel, Vector3 position, Vector2 sz, int text)
    {
        GameObject button = new GameObject();
        button.transform.parent = panel;

        button.AddComponent<TMPro.TextMeshProUGUI>();
        button.GetComponent<TMPro.TextMeshProUGUI>().text = text.ToString();

        button.AddComponent<RectTransform>();
        button.GetComponent<RectTransform>().sizeDelta = sz;
        button.transform.position = position;
    }
}
