using OWML.ModHelper;
using OWML.Common;

namespace AchievementsMod
{
    public class AchievementsMod : ModBehaviour
    {

        public static AchievementsMod Instance;
        
        private void Awake()
        {
            Instance = this;
        }
        private void Start()
        {
            // Starting here, you'll have access to OWML's mod helper.
            ModHelper.Console.WriteLine($"{nameof(AchievementsMod)} is ready to go!", MessageType.Success);
        }

        public static void Earn(Achievements.Type type)
        {
            AchievementsMod.Instance.ModHelper.Console.WriteLine($"{type} earned!", MessageType.Success);
        }
    }
}