using System;
using System.Collections.Generic;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(
            string name,
            int endurance,
            int sprint,
            int dribble,
            int passing,
            int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }
        public int Endurance
        {
            get => this.endurance;
            set
            {
                ValidateStat(value, nameof(Endurance));
                this.endurance = value;
            }
        }

        public int Sprint
        {
            get => sprint;
            set
            {
                ValidateStat(value, nameof(Sprint));
                this.sprint = value;
            }
        }

        public int Passing
        {
            get => passing;
            set
            {
                ValidateStat(value, nameof(Passing));
                this.passing = value;
            }
        }

        public int Shooting
        {
            get => shooting;
            set
            {
                ValidateStat(value, nameof(Shooting));
                this.shooting = value;
            }
        }

        public int Dribble
        {
            get => this.dribble;
            set
            {
                ValidateStat(value, nameof(Dribble));
                this.dribble = value;
            }
        }

        public int GetSkillLevel => SkillLevel();
        private int SkillLevel() => 
            (int)Math.Round((Endurance + Sprint + Passing + Shooting + Dribble) / 5.0);

        private void ValidateStat(int value, string statName)
        {
            if (IsValid(value))
            {
                throw new ArgumentException($"{statName} should be between 0 and 100.");
            }
        }

        private static bool IsValid(int value)
       => value <= 0 || value >= 100;
    }
}
