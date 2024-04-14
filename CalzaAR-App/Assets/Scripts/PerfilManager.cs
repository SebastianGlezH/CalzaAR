using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PerfilManager : MonoBehaviour
{
    public Button backButton;
    public Button logoutButton;

    private bool loggedIn = false; // Mantener el estado de inicio de sesi�n en esta clase

    private void Start()
    {
        backButton.onClick.AddListener(BackToPreviousScene);
        logoutButton.onClick.AddListener(Logout);

        // Verificar el estado de inicio de sesi�n solo si a�n no se ha verificado en esta instancia
        if (!loggedIn)
        {
            CheckLoginStatus();
        }
    }

    // Este m�todo se llama cuando se vuelve a la escena del perfil
    public void OnEnable()
    {
        // Verificar el estado de inicio de sesi�n si no est� logeado
        if (!loggedIn)
        {
            CheckLoginStatus();
        }
    }

    public void CheckLoginStatus()
    {
        if (!SessionManager.Instance.IsUserLoggedIn())
        {
            // Si el usuario no ha iniciado sesi�n, volver a la escena de inicio de sesi�n
            SceneManager.LoadScene("Perfil");
        }
        else
        {
            // Actualizar el estado de inicio de sesi�n en esta clase
            loggedIn = false;
        }
    }

    public void BackToPreviousScene()
    {
        // Implementa la l�gica para volver a la escena anterior seg�n tus necesidades
    }

    public void Logout()
    {
        // Llama al m�todo de cierre de sesi�n del SessionManager
        SessionManager.Instance.Logout();
        // Actualizar el estado de inicio de sesi�n en esta clase
        loggedIn = false;
    }
}
