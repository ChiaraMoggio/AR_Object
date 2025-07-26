using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// this script is for transfromation such as moving, rotation, scaling and raising lower
//
// TO DO:
// create move btn
// rotate btn
// scale bttn
// raise Lower btn
// change mode
//

public class TransformationManager : MonoBehaviour
{
    public GameObject target;
    [SerializeField] private string currentMode = "None";
    [Header("UI Buttons")]
    [SerializeField] private Button btn_move;
    [SerializeField] private Button btn_rotate;
    [SerializeField] private Button btn_scale;
    [SerializeField] private Button btn_RaiseUpDwn;

    // Start is called before the first frame update
    void Start()
    {
        btn_move.onClick.AddListener(() => SetMode("Move"));
        btn_rotate.onClick.AddListener(() => SetMode("Rotate"));
        btn_scale.onClick.AddListener(() => SetMode("Scale"));
        btn_RaiseUpDwn.onClick.AddListener(() => SetMode("RaiseLower"));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1 && target != null)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 delta = touch.deltaPosition;
                switch (currentMode)
                {
                    case "Move":
                        target.transform.position += new Vector3(delta.x, 0, delta.y) * 1f;
                        Debug.Log("moving");
                        break;
                    case "Rotate":
                        target.transform.Rotate(0, -delta.x * 0.5f, 0);
                        Debug.Log("rotating");

                        break;
                    case "Scale":
                        float scaleChange = delta.y * 0.005f;
                        target.transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
                        Debug.Log("scaling");

                        break;
                    case "RaiseLower":
                        target.transform.position += new Vector3(0, delta.y * 0.0005f, 0);
                        Debug.Log("raising lower");

                        break;
                }
            }
        }
    }

    public void SetMode(string mode)
    {
        currentMode = mode;
        Debug.Log(" transformation activated: " + currentMode);
    }

  
    public void SetTarget(GameObject obj)
    {
        target = obj;
    }
}
