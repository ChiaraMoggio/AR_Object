using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class placeAudi : MonoBehaviour
{
    public GameObject prefabPlaced;
    public ARRaycastManager RaycastManager;
    public TransformationManager transformationManager;

    private GameObject spawnedPrefab;
    static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

    void Update()
    {
        if (Input.touchCount > 0 && spawnedPrefab == null)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Vector2 touchPosition = touch.position;

                if (RaycastManager.Raycast(touchPosition, s_Hits, TrackableType.PlaneWithinPolygon))
                {
                    Pose hitPose = s_Hits[0].pose;

                    spawnedPrefab = Instantiate(prefabPlaced, hitPose.position, hitPose.rotation);
                    spawnedPrefab.transform.localScale = Vector3.one * 0.1f;

                    transformationManager.SetTarget(spawnedPrefab);

                    Debug.Log("prefab instanciated");
                }
            }
        }
    }
}
