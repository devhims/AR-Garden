using System.Collections;
using System.Collections.Generic;
using Hims.Arsenal;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementManager : MonoBehaviour
{
    [SerializeField] ARRaycastManager raycastManager;
    [SerializeField] int maxPlants = 100;

    Vector2 screenCenter;
    float sphereRadius = 0.1f;
    List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();
    Pose hitPose;
    List<GameObject> activePlants = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        screenCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (raycastManager.Raycast(screenCenter, raycastHits, TrackableType.PlaneWithinBounds))
        {
            hitPose = raycastHits[0].pose;

            if (!Physics.CheckSphere(hitPose.position, sphereRadius))
            {
          
                if (activePlants.Count >= maxPlants)
                {
                    EasyPool.Instance.ReturnObj(activePlants[0]);
                    activePlants.RemoveAt(0);
                }

                GameObject go = EasyPool.Instance.GetObj();
                go.transform.position = hitPose.position;
                go.SetActive(true);
                activePlants.Add(go);
            }
        }
    }
}
