using UnityEngine;

public class EventsSFX : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private ParticleSystem particleSystem;

    #endregion

    private void OnEnable()
    {
        EventsGameManager.OnEnterPressed += StartParticleSystem;
        EventsGameManager.OnEscapePressed += StopParticleSystem;
    }

    private void OnDisable()
    {
        EventsGameManager.OnEnterPressed -= StartParticleSystem;
        EventsGameManager.OnEscapePressed -= StopParticleSystem;
    }

    private void Awake()
    {
        StopParticleSystem();
    }

    private void StartParticleSystem()
    {
        particleSystem.Play();
    }
    
    private void StopParticleSystem()
    {
        particleSystem.Stop();
    }
}
