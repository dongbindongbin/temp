using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private List<Sprite> sprites;

    private bool[] crewStats = new bool[12];
    private float timer = 0.5f;
    private float distance = 11f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            SpawnFloatingCrew((EPlayerColor)i, Random.Range(0f, distance));
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f) // 타이머가 0이 되면
        {
            SpawnFloatingCrew((EPlayerColor)Random.Range(0, 12), distance);
            timer = 1f; // 다시 1로 초기화
        }


    }

    public void SpawnFloatingCrew(EPlayerColor playerColor, float dist)
    {
       if (!crewStats[(int)playerColor])
        {
            crewStats[(int)playerColor] = true;
            float angle = Random.Range(0f, 360f);
            Vector3 SpawnPos = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle), 0f) * distance;
            Vector3 direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f);
            float floatingSpeed = Random.Range(1f, 2f);
            float rotatingSpeed = Random.Range(-3f, 3f);

            var crew = Instantiate(prefab, SpawnPos, Quaternion.identity).GetComponent<FloatingCrew>();
            crew.SetFloatingCrew(sprites[Random.Range(0, sprites.Count)], playerColor, direction, floatingSpeed, rotatingSpeed, Random.Range(0.5f, 1f));
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        var crew = collision.GetComponent<FloatingCrew>();
        if (crew != null)
        {
            crewStats[(int)crew.playerColor] = false;
            Destroy(crew.gameObject);
        }
    }

}
