using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelselect : MonoBehaviour
{
    public string[] arrayTitles;
    public Sprite[] arraySprites;
    public GameObject button;
    public GameObject content;

    private List<GameObject> list = new List<GameObject>();
    private VerticalLayoutGroup _group;

    void Start()
    {
        RectTransform rectT = content.GetComponent<RectTransform>();
        rectT.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
        _group = GetComponent<VerticalLayoutGroup>();
        setLevels();
    }

    private void RemovedList()
    {
        foreach (var elem in list)
        {
            Destroy(elem);
        }
        list.Clear();
    }

    void setLevels()
    {
        RectTransform rectT = content.GetComponent<RectTransform>();
        rectT.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
        RemovedList();
        if (arrayTitles.Length > 0)
        {
            var pr1 = Instantiate(button, transform);
            var h = pr1.GetComponent<RectTransform>().rect.height;
            var tr = GetComponent<RectTransform>();
            tr.sizeDelta = new Vector2(tr.rect.width, h * arrayTitles.Length);
            Destroy(pr1);
            for (int i = 0; i < arrayTitles.Length; i++)
            {
                var pr = Instantiate(button, transform);
                pr.GetComponentInChildren<Text>().text = arrayTitles[i];
                var i1 = i;
                pr.GetComponent<Button>().onClick.AddListener(()=> GetLevel(i1));
                list.Add(pr);
            }
        }
    }
    
    void GetLevel(int id)
    {
        switch (id)
        {
            case 0:
                Debug.Log(id);
                break;
            case 1:
                Debug.Log(id);
                break;
        }
    }
}
