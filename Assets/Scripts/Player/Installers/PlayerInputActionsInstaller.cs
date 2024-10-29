using UnityEngine;
using Zenject;

public class PlayerInputActionsInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        PlayerInputActions playerInputActions = new PlayerInputActions();
        Container.Bind<PlayerInputActions>().FromInstance(playerInputActions).AsSingle().NonLazy();
    }
}