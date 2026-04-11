using UnityEngine;

public class PlotScript : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Color hoverColor;

    private GameObject tower;
    private Color startColor;

    private void Start()
    {
        startColor = sr.color;
    }

    private void OnMouseEnter()
    {
        sr.color = hoverColor;
    }

    private void OnMouseExit()
    {
        sr.color = startColor;
    }

    private void OnMouseDown()
    {
        if (tower != null) return;

        TowerTest towerToBuild = BuildManager.main.GetSelectedTower();

        if (towerToBuild.cost > LevelManager2.main.boneCurrency)
        {
            Debug.Log("You can't afford this tower");
            return;
        }

        LevelManager2.main.SpendBones(towerToBuild.cost);
        tower = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);
    }
}
