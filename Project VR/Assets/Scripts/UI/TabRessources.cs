using System.Collections.Generic;
using UnityEngine;

public class TabRessources : Tab
{
    public GameObject ressourcePrefab;
    public Transform resssourcesParent;

    List<RessourceUI> ressourcesUIs = new List<RessourceUI>();
 
    public override void UpdateContent(Piece piece)
    {
        ClearRessources();
        if (piece == null || piece.ressources==null) return;
        for (int i = 0; i < piece.ressources.Length; i += 1)
        {
            AddRessource(piece.ressources[i]);
        }
    }

    void ClearRessources()
    {
        for (int i = 0; i < ressourcesUIs.Count; i += 1)
        {
            Destroy(ressourcesUIs[i].gameObject);
        }
        ressourcesUIs.Clear();
    }

    void AddRessource(Ressource ressource)
    {
        RessourceUI ressourceUI = Instantiate<GameObject>(ressourcePrefab, resssourcesParent).GetComponent<RessourceUI>();
        ressourcesUIs.Add(ressourceUI);
        ressourceUI.UpdateContent(ressource);
    }
}
