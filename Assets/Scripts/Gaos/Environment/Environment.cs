using System.Collections.Generic;
using UnityEngine;

namespace Gaos.Environment
{
    public class Environment : MonoBehaviour
    {
        private static bool wasEnvironmentNamePrinted = false;

        public static Dictionary<string, string> GetEnvironment_(string envName)
        {
            Dictionary<string, string> env = new Dictionary<string, string>();

            if (envName == "Development")
            {
                if (!wasEnvironmentNamePrinted)
                {
                    Debug.Log("Environment: Development");
                    wasEnvironmentNamePrinted = true;
                }
                env.Add("ENV_NAME", "Development");
                env.Add("GAOS_URL", "https://local.galacticodyssey.space/gaos");
                env.Add("GAOS_WS", "wss://local.galacticodyssey.space/gaos/ws");
                env.Add("IS_PROFILE_HTTP_CALLS", "true");
                env.Add("RELEASE_URL", "https://local.galacticodyssey.space/release");

                env.Add("IS_SEND_GAME_DATA_DIFF", "true");

                env.Add("IS_DEBUG", "true");
                env.Add("IS_DEBUG_GAME_DATA", "false");
                env.Add("IS_DEBUG_SEND_GAMEDATA_BASE", "false");
            } 
            else if (envName == "Development_multi")
            {
                if (!wasEnvironmentNamePrinted)
                {
                    Debug.Log("Environment: Development_multi");
                    wasEnvironmentNamePrinted = true;
                }
                env.Add("ENV_NAME", "Development_multi");
                env.Add("GAOS_URL", "https://local.galacticodyssey.space/gaos");
                env.Add("GAOS_WS", "wss://local.galacticodyssey.space/gaos/ws_multi");
                env.Add("IS_PROFILE_HTTP_CALLS", "true");
                env.Add("RELEASE_URL", "https://local.galacticodyssey.space/release");

                env.Add("IS_SEND_GAME_DATA_DIFF", "true");

                env.Add("IS_DEBUG", "true");
                env.Add("IS_DEBUG_GAME_DATA", "false");
                env.Add("IS_DEBUG_SEND_GAMEDATA_BASE", "false");
            }
            else if (envName == "Test")
            {
                if (!wasEnvironmentNamePrinted)
                {
                    Debug.Log("Environment: Test");
                    wasEnvironmentNamePrinted = true;
                }
                env.Add("ENV_NAME", "Test");
                env.Add("GAOS_URL", "https://test.galacticodyssey.space/gaos");
                env.Add("GAOS_WS", "wss://test.galacticodyssey.space/gaos/ws");
                env.Add("IS_PROFILE_HTTP_CALLS", "false");
                env.Add("RELEASE_URL", "https://test.galacticodyssey.space/release");

                env.Add("IS_SEND_GAME_DATA_DIFF", "true");

                env.Add("IS_DEBUG", "true");
                env.Add("IS_DEBUG_GAME_DATA", "false");
                env.Add("IS_DEBUG_SEND_GAMEDATA_BASE", "false");

            }
            else
            {
                throw new System.Exception($"Environment not found: {envName}");
            }


            return env;
        }

        public static Dictionary<string, string> GetEnvironment()
        {
            //return Environment.GetEnvironment_("Test");
            return GetEnvironment_("Development_multi");
            //return GetEnvironment_("Development");
        }

    }


}