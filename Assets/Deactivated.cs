using UnityEngine;

public class Deactivated : MonoBehaviour
{
    [Header("Объект для активации")]
    [SerializeField] private GameObject targetObject;

    [Header("Тег игрока")]
    [SerializeField] private string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            if (targetObject != null)
            {
                targetObject.SetActive(false);
            }
            else
            {
                Debug.LogWarning("Target Object не назначен!");
            }
        }
    }
}
