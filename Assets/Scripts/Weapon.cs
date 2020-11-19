using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Weapon : MonoBehaviour
{
    public Transform barrel = null;
    public GameObject projectilePrefab = null;
    private XRGrabInteractable interactable = null;

    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()
    {
        interactable.onActivate.AddListener(Fire);
    }

    private void OnDisable()
    {
        interactable.onActivate.RemoveListener(Fire);
    }

    private void Fire(XRBaseInteractor interactor)
    {
        CreateProjectile();
    }

    public void CreateProjectile()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, barrel.position, barrel.rotation);
        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch();
    }
}
