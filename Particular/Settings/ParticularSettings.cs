using System;
using System.Collections.Generic;
using System.Linq;
using BeatSaberMarkupLanguage.Attributes;

namespace Particular.Settings
{
    public class ParticularSettings : PersistentSingleton<ParticularSettings>
    {
        internal const float Infinity = 100000f;

        [UIValue("particle-values")]
        internal List<object> ParticleValues = new object[]
            {
                0f,
                0.1f,
                0.2f,
                0.3f,
                0.4f,
                0.5f,
                0.6f,
                0.7f,
                0.8f,
                0.9f,
                1f,
                1.1f,
                1.2f,
                1.3f,
                1.4f,
                1.5f,
                1.6f,
                1.7f,
                1.8f,
                1.9f,
                2f,
                2.25f,
                2.5f,
                2.75f,
                3f,
                3.25f,
                3.5f,
                3.75f,
                4f,
                4.25f,
                4.5f,
                4.75f,
                5f,
                5.5f,
                6f,
                6.5f,
                7f,
                7.5f,
                8f,
                8.5f,
                9f,
                9.5f,
                10f,
                11f,
                12f,
                13f,
                14f,
                15f,
                16f,
                17f,
                18f,
                19f,
                20f,
                22.5f,
                25f,
                27.5f,
                30f,
                32.5f,
                35f,
                37.5f,
                40f,
                42.5f,
                45f,
                47.5f,
                50f,
                55f,
                60f,
                65f,
                70f,
                75f,
                80f,
                85f,
                90f,
                100f,
                110f,
                120f,
                130f,
                140f,
                150f,
                160f,
                170f,
                180f,
                190f,
                200f,
                300f,
                400f,
                500f,
                1000f
            }.ToList();

        [UIValue("lifetime-values")]
        internal List<object> LifetimeValues = new object[]
            {
                0f,
                0.1f,
                0.2f,
                0.3f,
                0.4f,
                0.5f,
                0.6f,
                0.7f,
                0.8f,
                0.9f,
                1f,
                1.1f,
                1.2f,
                1.3f,
                1.4f,
                1.5f,
                1.6f,
                1.7f,
                1.8f,
                1.9f,
                2f,
                2.25f,
                2.5f,
                2.75f,
                3f,
                3.25f,
                3.5f,
                3.75f,
                4f,
                4.25f,
                4.5f,
                4.75f,
                5f,
                Infinity,
            }.ToList();

        [UIValue("slash-particles")]
        public float SlashParticles
        {
            get => Plugin.config.GetFloat("particles", "slash-particles") ?? 1f;
            set => Plugin.config.SetFloat("particles", "slash-particles", value);
        }

        [UIValue("explosion-particles")]
        public float ExplosionParticles
        {
            get => Plugin.config.GetFloat("particles", "explosion-particles") ?? 1f;
            set => Plugin.config.SetFloat("particles", "explosion-particles", value);
        }

        [UIValue("particle-lifetime")]
        public float ParticleLifetime
        {
            get => Plugin.config.GetFloat("particles", "particle-lifetime") ?? 1f;
            set => Plugin.config.SetFloat("particles", "particle-lifetime", value);
        }

        [UIAction("format-percentage")]
        public string FormatValue(float val)
        {
            if (val >= Infinity)
                return "Infinity";
            else
                return $"{val * 100}%";
        }

        [UIValue("camera-noise")]
        public bool CameraNoise
        {
            get => Plugin.config.GetBoolean("global", "camera-noise") ?? true;
            set => Plugin.config.SetBoolean("global", "camera-noise", value);
        }

        [UIValue("world-particles")]
        public bool WorldParticles
        {
            get => Plugin.config.GetBoolean("global", "world-particles") ?? true;
            set => Plugin.config.SetBoolean("global", "world-particles", value);
        }

        [UIAction("#apply")]
        internal void OnApply()
        {

        }
    }
}
