using UnityEngine;
using TMPro;
using UnityEngine.UI;
using NaughtyAttributes;

public class carddisplay : MonoBehaviour
{
    [SerializeField] private so_card _cardProfile;
    
    [Header("Character Detail")]

    [SerializeField] private TMP_Text _name;

    [SerializeField] private TMP_Text _description;

    [SerializeField] private TMP_Text _type;

    [Space]

    [SerializeField] private Image _characterImage;

    [Header("Character Attributes")] 


    [SerializeField] private TMP_Text _costText;

    [SerializeField] private TMP_Text _healthText;

    [SerializeField] private TMP_Text _atkText;

    [Button]

    public void SetupCard()
    {

        _name.text = _cardProfile.Name;
        _description.text = _cardProfile.Description;
        _type.text = _cardProfile.ElementalType.ToString();

        _costText.text = _cardProfile.Cost.ToString();
        _healthText.text = _cardProfile.Health.ToString();
        _atkText.text = _cardProfile.ATK.ToString();
    }
}
