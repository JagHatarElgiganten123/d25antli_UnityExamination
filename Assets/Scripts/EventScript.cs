using System;
using UnityEngine;
using UnityEngine.Events;

public class EventScript : MonoBehaviour
{
    [SerializeField] private Material material;
    public UnityEvent coolEvent;

    private void Start()
    {
        coolEvent?.Invoke();
    }

    public void ChangeMaterial(MeshRenderer renderer)
    {
        renderer.material = material;
    }
}
