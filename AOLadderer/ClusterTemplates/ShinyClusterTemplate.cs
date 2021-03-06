﻿using AOLadderer.Stats;
using System.Collections.Generic;

namespace AOLadderer.ClusterTemplates
{
    public sealed class ShinyClusterTemplate : ClusterTemplate
    {
        private ShinyClusterTemplate(Stat stat, ImplantSlot implantSlot)
            : base(stat, ClusterGrade.Shiny, implantSlot)
        { }

        public override int GetStatIncrease(int implantQL)
            => Stat.GetShinyStatIncrease(implantQL);

        public override int GetMinimumClusterQL(int implantQL)
            => (int)(.86 * implantQL);

        public static readonly IReadOnlyList<ShinyClusterTemplate> ShinyClusterTemplates = new[]
        {
            new ShinyClusterTemplate(Skill.OneHandBlunt, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.OneHandEdgedWeapon, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.TwoHandBlunt, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.TwoHandEdged, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.Adventuring, ImplantSlot.Leg),
            new ShinyClusterTemplate(Ability.Agility, ImplantSlot.Leg),
            new ShinyClusterTemplate(Skill.AimedShot, ImplantSlot.Eye),
            new ShinyClusterTemplate(Skill.AssaultRif, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.BioMetamor, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.BodyDev, ImplantSlot.Chest),
            new ShinyClusterTemplate(Skill.Bow, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.BowSpcAtt, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.Brawling, ImplantSlot.LeftArm),
            new ShinyClusterTemplate(Skill.BreakAndEntry, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.Burst, ImplantSlot.RightArm),
            new ShinyClusterTemplate(ArmorClass.ChemicalAC, ImplantSlot.Waist),
            new ShinyClusterTemplate(Skill.Chemistry, ImplantSlot.Head),
            new ShinyClusterTemplate(ArmorClass.ColdAC, ImplantSlot.Waist),
            new ShinyClusterTemplate(Skill.CompLiter, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.Concealment, ImplantSlot.Feet),
            new ShinyClusterTemplate(Skill.Dimach, ImplantSlot.Chest),
            new ShinyClusterTemplate(ArmorClass.DiseaseAC, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.DodgeRng, ImplantSlot.Leg),
            new ShinyClusterTemplate(Skill.DuckExp, ImplantSlot.Leg),
            new ShinyClusterTemplate(Skill.ElecEngi, ImplantSlot.Eye),
            new ShinyClusterTemplate(ArmorClass.EnergyAC, ImplantSlot.Chest),
            new ShinyClusterTemplate(Skill.EvadeClsC, ImplantSlot.Feet),
            new ShinyClusterTemplate(Skill.FastAttack, ImplantSlot.LeftHand),
            new ShinyClusterTemplate(ArmorClass.FireAC, ImplantSlot.Waist),
            new ShinyClusterTemplate(Skill.FirstAid, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.FlingShot, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.FullAuto, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.Grenade, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.HeavyWeapons, ImplantSlot.RightArm),
            new ShinyClusterTemplate(ArmorClass.ImpProjAC, ImplantSlot.Leg),
            new ShinyClusterTemplate(Ability.Intelligence, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.MartialArts, ImplantSlot.RightHand),
            new ShinyClusterTemplate(Skill.MattMetam, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.MatterCrea, ImplantSlot.Head),
            new ShinyClusterTemplate(MaxHealthOrNano.MaxHealth, ImplantSlot.Chest),
            new ShinyClusterTemplate(MaxHealthOrNano.MaxNano, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.MechEngi, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.MeleeEner, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.MeleeInit, ImplantSlot.Feet),
            new ShinyClusterTemplate(ArmorClass.MeleeMaAC, ImplantSlot.Chest),
            new ShinyClusterTemplate(Skill.MGSMG, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.MultMelee, ImplantSlot.LeftWrist),
            new ShinyClusterTemplate(Skill.MultiRanged, ImplantSlot.LeftWrist),
            new ShinyClusterTemplate(Skill.NanoPool, ImplantSlot.Chest),
            new ShinyClusterTemplate(Skill.NanoProgra, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.NanoResist, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.NanoCInit, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.Parry, ImplantSlot.RightWrist),
            new ShinyClusterTemplate(Skill.Perception, ImplantSlot.Ear),
            new ShinyClusterTemplate(Skill.PharmaTech, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.PhysicInit, ImplantSlot.Feet),
            new ShinyClusterTemplate(Skill.Piercing, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.Pistol, ImplantSlot.RightWrist),
            new ShinyClusterTemplate(Ability.Psychic, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.PsychoModi, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.Psychology, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.QuantumFT, ImplantSlot.Head),
            new ShinyClusterTemplate(ArmorClass.RadiationAC, ImplantSlot.Waist),
            new ShinyClusterTemplate(Skill.RangedEner, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.RangedInit, ImplantSlot.RightWrist),
            new ShinyClusterTemplate(Skill.Rifle, ImplantSlot.Eye),
            new ShinyClusterTemplate(Skill.Riposte, ImplantSlot.RightWrist),
            new ShinyClusterTemplate(Skill.RunSpeed, ImplantSlot.RightWrist),
            new ShinyClusterTemplate(Ability.Sense, ImplantSlot.Chest),
            new ShinyClusterTemplate(Skill.SensoryImpr, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.SharpObj, ImplantSlot.RightWrist),
            new ShinyClusterTemplate(Skill.Shotgun, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.SneakAtck, ImplantSlot.Feet),
            new ShinyClusterTemplate(Ability.Stamina, ImplantSlot.Chest),
            new ShinyClusterTemplate(Ability.Strength, ImplantSlot.RightArm),
            new ShinyClusterTemplate(Skill.TimeAndSpace, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.TrapDisarm, ImplantSlot.RightHand),
            new ShinyClusterTemplate(Skill.Treatment, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.Tutoring, ImplantSlot.Eye),
            new ShinyClusterTemplate(Skill.VehicleAir, ImplantSlot.Eye),
            new ShinyClusterTemplate(Skill.VehicleGrnd, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.VehicleHydr, ImplantSlot.Head),
            new ShinyClusterTemplate(Skill.WeaponSmt, ImplantSlot.RightHand),
        };
    }
}
