using DynamicPlugins.Infrastructure;
using DynamicPlugins.Data;
using DynamicPlugins.ViewModels;

namespace DemoPlugin4.Migrations
{
    public class Migration_1_0_0 : BaseMigration
    {
        private static PluginVersion _version = new PluginVersion("1.0.0");
        public Migration_1_0_0(MyContext myContext) : base(myContext, _version)
        {

        }

        public override string UpScripts
        {
            get
            {
                return @"DROP TABLE IF EXISTS `Test4`;
                        CREATE TABLE `Test2`  (
                          `Id` char(36) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
                          `Version` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NULL
                        ) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;";
            }
        }

        public override string DownScripts
        {
            get
            {
                return @"DROP TABLE IF EXISTS `Test4`;";
            }
        }
    }
}
