using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/PlayerData", order = 0)]
public class PlayerData : ScriptableObject
{
    [SerializeField] private int _playersStartHealth;
    [SerializeField] private int _playerMaxForce;

    public int PlayerStartHealth => _playersStartHealth;
    public int PlayerMaxForce => _playerMaxForce;
}