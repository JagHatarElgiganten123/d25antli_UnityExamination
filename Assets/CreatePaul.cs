using UnityEngine;
using UnityEngine.Events;

public class CreatePaul : MonoBehaviour
{
    [SerializeField] private Transform pos;
    public UnityEvent createPaul;
    void Start()
    {
        createPaul?.Invoke();
    }

    public void PaulInstantaite(GameObject gameObject)
    {
        Instantiate(gameObject, pos);
    }
}
