using System;
using Server;
using Server.Gumps;

namespace Server.Mobiles
{
    public class TrainingPoint
    {
        public object TrainPoint { get; set; }
        public double Weight { get; set; }
        public int Max { get; set; }
        public TextDefinition Name { get; set; }
        public TextDefinition Description { get; set; }

        public TrainingPointRequirement[] Requirements { get; set; }

        public TrainingPoint(object trainpoint, double weight, int max, TextDefinition name, TextDefinition description, params TrainingPointRequirement[] requirements)
        {
            TrainPoint = trainpoint;
            Weight = weight;
            Max = max;

            Name = name;
            Description = description;

            Requirements = requirements;
        }
    }

    public class TrainingPointRequirement
    {
        public object Requirement { get; set; }
        public int Cost { get; set; }

        public TrainingPointRequirement(object requirement, int cost)
        {
            Requirement = requirement;
            Cost = cost;
        }
    }
}
