using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SpawnPlanets : MonoBehaviour
{
    private string[] planets = { "Planet1", "Planet2", "Planet3","Planet4","Planet5","Sun"};
    private List<GameObject> planetObjects = new List<GameObject>();
    private Random rand = new Random();
    float time = 0f;

    void Start() {
        newPlanet();
    }

    void Update()
    {
        float interval;
        if (((float) Screen.width) / ((float)Screen.height) > 1.25f)
        {
            Debug.Log("here");
            interval = 0.7f;
        }
        else
        {
            interval = 1f;
        }
        time += Time.deltaTime;
        if (time >= interval)
        {
            time = time % interval;
            newPlanet();
        }

        Vector3 screenBottom= Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane + 30));
        for (int i = 0; i < planetObjects.Count; i++)
        {
            GameObject planet = planetObjects[i];
            if (planetObjects[i].transform.position.y <= screenBottom.y-5)
            {
                Destroy(planet);
                planetObjects.RemoveAt(i);
            }
        }
    }

    void newPlanet()
    {
        int index = rand.Next(planets.Length);
        Object planet = Resources.Load(planets[index]);
        var planetObj = Instantiate(planet,
            Camera.main.ScreenToWorldPoint(new Vector3(rand.Next(0, Camera.main.pixelWidth), Camera.main.pixelHeight + 150, Camera.main.nearClipPlane + 30)),
            Quaternion.Euler(new Vector3(rand.Next(0, 360), rand.Next(0, 360), rand.Next(0, 360)))) as GameObject; 
        planetObj.tag = "Planet";
        planetObjects.Add(planetObj);
    }
}

