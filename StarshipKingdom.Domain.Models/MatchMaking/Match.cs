﻿using System;
using System.Collections.Generic;

namespace StarshipKingdom.Domain.Models.MatchMaking
{
    public class Match
    {
        public long Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public User Creator { get; set; }

        public virtual IEnumerable<Ship> Participants { get; set; }
    }
}