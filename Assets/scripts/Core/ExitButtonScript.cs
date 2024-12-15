using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonScript : MonoBehaviour
{
    // This method will be called when the button is pressed
    public void ExitGame()
    {
        // If running in the editor, stop play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // If running as a standalone build, quit the application
            Application.Quit();
#endif
    }
}
