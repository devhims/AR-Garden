using System.Collections;
using System.Collections.Generic;
using Hims.Arsenal;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementManager : MonoBehaviour
{
    [SerializeField] ARRaycastManager raycastManager;

    int maxPlants;
    Vector2 screenCenter;
    float sphereRadius = 0.1f;
    List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();
    Pose hitPose;

    // stores all plants available in ar experience
    List<GameObject> activePlants = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // cast ray from the center of the screen
        screenCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);

        // set max plants number to the pool size declared in the inspector for EasyPool component in the scene 
        maxPlants = EasyPool.Instance.PoolSize;

        // prevent screen timout while using the app 
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    // Update is called once per frame
    void Update()
    {
        if (raycastManager.Raycast(screenCenter, raycastHits, TrackableType.PlaneWithinBounds))
        {
            hitPose = raycastHits[0].pose;

            // proceed if not overlapping any other collider in the specified radius
            if (!Physics.CheckSphere(hitPose.position, sphereRadius))
            {
                if (activePlants.Count >= maxPlants)
                {
                    // return the first object in the list and shrink the list on exceeding max count
                    EasyPool.Instance.ReturnObj(activePlants[0]);
                    activePlants.RemoveAt(0);
                    return;
                }

                GameObject go = EasyPool.Instance.GetObj();
                go.transform.position = hitPose.position;
                go.SetActive(true);
                activePlants.Add(go);
            }
        }
    }
}
