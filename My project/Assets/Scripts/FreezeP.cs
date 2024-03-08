using System.Collections;
using UnityEngine;

public class FreezeP : MonoBehaviour
{
    public float freezeDuration = 5f; // Duration in seconds to freeze enemies

    private void OnMouseDown()
    {
        StartCoroutine(FreezeEnemiesCoroutine());
    }

    IEnumerator FreezeEnemiesCoroutine()
    {
        // Find all objects tagged as "Trash"
        GameObject[] trash = GameObject.FindGameObjectsWithTag("Trash");

        // Disable trash
        foreach (GameObject obj in trash)
        {
            obj.SetActive(false);
        }

        // Wait for the freeze duration
        yield return new WaitForSeconds(freezeDuration);

        // Enable trash after freeze duration
        foreach (GameObject obj in trash)
        {
            obj.SetActive(true);
        }
    }
}
