using System;

namespace GameOverrideDemo
{
    public class PhysicalSkill : Skill
    {
        private float critRate;

        public PhysicalSkill()
        {
            critRate = 0.1f;
            Console.WriteLine("-----> Konstrukto default PhysicalSkill <-----");
        }

        public PhysicalSkill(float critRate, string name, float power, float cost)
            : base(name, power, cost)
        {
            Console.WriteLine("-----> Konstruktor berparameter PhysicalSkill <-----");
            this.critRate = critRate;
        }

        public override float CalculateDamage()
        {
            Console.WriteLine("[PhysicallSkill.CalculateDamage] Menghitung damage fisik dengan critical hit...");
            float damage = basePower + (1 + critRate);
            return basePower * (1+ critRate);
           
        }

        public float CalculateDamage(bool isBackstab)
        {
            Console.WriteLine($"[PhysicalSkill.CalculateDamage] Menghitng damage fisik dengan backstab: {isBackstab}");
            float damage = basePower * (1 + critRate);
            if (isBackstab)
                damage *= 1.5f;
                return damage;
        }

        public new void DisplaySkillInfo()
        {
            base.DisplaySkillInfo();
            Console.WriteLine("CRIT RATE     : " + (critRate * 100) + "%");
            Console.WriteLine("========================");
        }
    }
}