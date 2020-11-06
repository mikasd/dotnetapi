using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderResository : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="testHowTo", Line="testLine", Platform="linux"},
                new Command{Id=1, HowTo="testHowTo1", Line="testLine1", Platform="linux1"},
                new Command{Id=2, HowTo="testHowTo2", Line="testLine2", Platform="linux2"},
                new Command{Id=3, HowTo="testHowTo3", Line="testLine3", Platform="linux3"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="testHowTo", Line="testLine", Platform="linux"};
        }
    }
}