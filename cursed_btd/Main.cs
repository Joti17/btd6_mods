﻿using MelonLoader;
using Harmony;
using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;
using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;
using Assets.Scripts.Unity.UI_New.Main;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Towers;

using Assets.Scripts.Unity;



using Assets.Scripts.Simulation.Towers;

using Assets.Scripts.Utils;

using Il2CppSystem.Collections;
using Assets.Scripts.Unity.UI_New.Popups;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Models;
using TMPro;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using UnityEngine;
using System.Linq;

namespace cursed_btd
{
    public class Main : MelonMod
    {

        public static System.Random r = new System.Random();
        public static float amount = 0.2f;
        public static string[] filter = new string[]
        {
            "terrain",
            "camera",
        };

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            System.Console.WriteLine("cursed_btd loaded");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
            {
                if (filter.Any(ob.name.ToLower().Contains))
                    continue;
                ob.transform.position += new Vector3(r.NextDouble() > 0.5f ? amount : -amount, r.NextDouble() > 0.5f ? amount : -amount, r.NextDouble() > 0.5f ? amount : -amount);
            }
        }





    }

}