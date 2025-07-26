using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class placeAudi : MonoBehaviour
{
    public GameObject m_PlacedPrefab;
    public ARRaycastManager m_RaycastManager;

    static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start HEY");
    }

    
    void Update()
    {
        Debug.Log("Update HEY");
        if (Input.touchCount == 0)
        {
            Debug.Log("NO TOUCH HEY");
        }
        if (Input.touchCount > 0)
        {
            Debug.Log("Touch detected HEY");
            Touch touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("Touch began HEY");
                Vector2 touchPosition = touch.position;

                if (m_RaycastManager.Raycast(touchPosition, s_Hits, TrackableType.PlaneWithinPolygon))
                {
                    Pose hitPose = s_Hits[0].pose;
                    Debug.Log("Hit on plane at: HEY" + hitPose.position);

                    GameObject spawned = Instantiate(m_PlacedPrefab);
                    spawned.transform.localScale = Vector3.one * 1f;
                }
                else
                {
                    Debug.Log("Raycast did not hit any plane HEY");
                }
            }
        }
    }
}
