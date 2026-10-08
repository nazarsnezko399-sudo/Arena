using UnityEngine;

public class LifecycleLogger : MonoBehaviour
{
    private bool firstFrameLogged;
    private void Awake()
    {
        Debug.Log($"Tutaj powinna byc liczba -> [{Time.frameCount}] Awake");
    }
    private void Update()
    {
        if ( !firstFrameLogged)
        {
            Debug.Log($"[{Time.frameCount}] Update (pierwsza klatka)");
            firstFrameLogged = true;
        }
    }
    void Start()
    {
        Debug.Log($"[{Time.frameCount}] Start");
    }

    private void OnEnable()
    {
        Debug.Log($"[{Time.frameCount}] OnEnable");
    }
    private void OnDisable()
    {
        Debug.Log($"[{Time.frameCount}] OnDisable");
    }
    private void OnDestroy()
    {
        Debug.Log($"[{Time.frameCount}] OnDestroy");
    }
}
