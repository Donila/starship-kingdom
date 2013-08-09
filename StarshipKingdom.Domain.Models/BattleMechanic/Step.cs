﻿namespace StarshipKingdom.Domain.Models.BattleMechanic
{
    public class Step
    {
        public long Id { get; set; }

        public byte HitCode { get; set; }

        public virtual Move Move { get; set; }

        public virtual User User { get; set; }
    }
}