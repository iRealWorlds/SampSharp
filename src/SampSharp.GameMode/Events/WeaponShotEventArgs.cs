﻿// SampSharp
// Copyright 2017 Tim Potze
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.World;

namespace SampSharp.GameMode.Events
{
    /// <summary>
    ///     Provides data for the <see cref="BaseMode.PlayerWeaponShot" /> or <see cref="BasePlayer.WeaponShot" /> event.
    /// </summary>
    public class WeaponShotEventArgs : PositionEventArgs
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="WeaponShotEventArgs" /> class.
        /// </summary>
        /// <param name="weaponType">The weaponType.</param>
        /// <param name="hittype">The hittype.</param>
        /// <param name="hitid">The hitid.</param>
        /// <param name="position">The position.</param>
        public WeaponShotEventArgs(WeaponType weaponType, BulletHitType hittype, int hitid, Vector3 position)
            : base(position)
        {
            WeaponType = weaponType;
            BulletHitType = hittype;
            HitId = hitid;
        }

        /// <summary>
        ///     Gets the weaponType.
        /// </summary>
        public WeaponType WeaponType { get; private set; }

        /// <summary>
        ///     Gets the type of the bullet hit.
        /// </summary>
        public BulletHitType BulletHitType { get; private set; }

        /// <summary>
        ///     Gets the hit identifier.
        /// </summary>
        public int HitId { get; private set; }

        /// <summary>
        ///     Gets or sets whether the bullets should be prevented from causing damage.
        /// </summary>
        public bool PreventDamage { get; set; }
    }
}