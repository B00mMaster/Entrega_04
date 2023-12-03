using UnityEngine;

public class EventsGameManager : MonoBehaviour
{
    // HERE YOU WILL HAVE TO DECLARE AND INVOKE THE EVENTS

    public delegate void OnEnterKeyPressed();
    public static event OnEnterKeyPressed OnEnterPressed;

    public delegate void OnEscapeKeyPressed();
    public static event OnEscapeKeyPressed OnEscapePressed;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            OnEnterPressed();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnEscapePressed();
        }

    }

   
}
