﻿namespace _InputTest.Entity.Scripts.Combat
{
    public class Attack
    {
        public int Damage { get; }
        public bool Critical { get; }

        public Attack(int damage, bool critical) => (Damage, Critical) = (damage, critical);
        
        
    }
}
