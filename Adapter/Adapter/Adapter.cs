using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adapter : IEnemy
    {
        EnemyRobot enemyRobot;

        public Adapter(EnemyRobot e)
        {
            enemyRobot = e;
        }
        public void enemyName(string name)
        {
            enemyRobot.RobotName(name);
        }

        public void run()
        {
            enemyRobot.Run();
        }

        public void useGun()
        {
            enemyRobot.Punch();
        }
    }
}
