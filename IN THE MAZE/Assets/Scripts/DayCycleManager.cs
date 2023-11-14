using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayCycleManager : MonoBehaviour
{
    [SerializeField] private Light sun;

    [Range(0,1)][SerializeField] private float timeOfDay;
    [SerializeField] private float dayDuration;
    private int dayCount;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeOfDay += Time.deltaTime / dayDuration;
        if (timeOfDay >= 1)
            timeOfDay -= 1;

        sun.transform.localRotation = Quaternion.Euler(timeOfDay * 360f, 180, 0);
        if(Input.GetKey(KeyCode.B))
        {
            SceneManager.LoadScene(0);
        }
    }

    //IEnumerator dayCycle()
    //{
    //    yield return new WaitForSeconds(timeOfDay);
    //}
}
