using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollText : MonoBehaviour
{

       RectTransform m_RectTransform;

    // Start is called before the first frame update
    void Start()
    {
           m_RectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        m_RectTransform.localPosition += Vector3.right * 7;


        if (m_RectTransform.localPosition.x >= 1300)
        {
                m_RectTransform.localPosition = new Vector2(-600,144);
        }
    }
}
