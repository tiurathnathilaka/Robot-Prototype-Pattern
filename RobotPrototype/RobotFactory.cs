using System.Collections.Generic;
namespace RobotPrototype
{
    public class RobotFactory
    {
        private Dictionary<string, IRobotPrototype> prototypes;
        public RobotFactory()
        {
            prototypes = new Dictionary<string, IRobotPrototype>();
        }

        public void RegisterPrototype(string name, IRobotPrototype robot)
        {
            prototypes[name] = robot;
        }

        public IRobotPrototype CreateRobot(string name)
        {
            if (prototypes.ContainsKey(name))
            {
                return prototypes[name].Clone();
            }

            return null;
        }
    }
}
