using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int count;

    [SerializeField]
    TextMeshPro _text;

    public int Count
    {
        get
        {
            return count;
        }
        set
        {
            count = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeVisibleCounter()
    {
        _text.text = count.ToString();
    }
}
