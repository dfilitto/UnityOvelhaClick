using UnityEngine;
using UnityEngine.EventSystems;


/* * ==============================================================================
 * GUIA DE CONFIGURAÇÃO PARA O CLIQUE FUNCIONAR (UNITY 6 + INPUT SYSTEM):
 * 1. NO OBJETO (OVELHA): 
 * - Adicione este Script.
 * - Adicione um 'BoxCollider2D' (é a "área de toque" do objeto).
 * 2. NA CAMERA (MAIN CAMERA):
 * - Adicione o componente 'Physics 2D Raycaster' (faz a ponte entre o mouse e o mundo 2D).
 * 3. NA CENA (HIERARCHY):
 * - Certifique-se de que existe um 'EventSystem' (botão direito > UI > Event System).
 * - No EventSystem, clique em "Replace with Input System UI Input Module" se houver um aviso.
 * ==============================================================================
 */


public class Sheep : MonoBehaviour, IPointerClickHandler
{

    // O método muda de OnMouseDown para OnPointerClick
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Ovelha clicada!!!!!");
        Destroy(gameObject);
    }

}
