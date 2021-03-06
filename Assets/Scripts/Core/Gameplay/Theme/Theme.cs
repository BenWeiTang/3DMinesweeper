using UnityEngine;
using Minesweeper.Audio;

namespace Minesweeper.Core
{
    [CreateAssetMenu(fileName = "Theme", menuName = "3D Minesweeper/Theme")]
    public class Theme : ScriptableObject
    {
        [Header("Camera")]
        public Color BackgroundColor;

        [Header("Material")]
        public Material DugEdgeMaterial;
        public Material DugBaseMaterial;
        public Material MarkedEdgeMaterial;
        public Material MarkedBaseMaterial;
        public Material MineEdgeMaterial;
        public Material MineBaseMaterial;
        public Material UntouchedEdgeMaterial;
        public Material UntouchedBaseMaterial;
        public Material OneMaterial;
        public Material TwoMaterial;
        public Material ThreeMaterial;
        public Material FourMaterial;
        public Material FiveMaterial;
        public Material SixMaterial;
        public Material SevenMaterial;
        public Material EightMaterial;

        [Header("Lighting")]
        [Tooltip("Tracking light is the light source that follows the position of the mouse. If the materials are unlit, enabling this option will have no effect.")]
        public bool UseTrackingLight = false;

        [Header("Audio")]
        public BGMSoundBank BGMSoundBank;
        public GameplayEffectSoundBank GameplayEffectSoundBank;
    }
}
