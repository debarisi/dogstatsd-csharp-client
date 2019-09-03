﻿namespace StatsdClient
{
    public class StatsdConfig
    {
        public string StatsdServerName { get; set; }
        public int StatsdPort { get; set; }
        public int StatsdMaxUDPPacketSize { get; set; }
        public bool StatsdTruncateIfTooLong { get; set; } = true;
        public string Prefix { get; set; }
 
/// <summary>
/// On each metric there will be no IO wait and there is no guarantee that metric will be send
/// </summary>
        public bool FireAndForget { get; set; }
        
        public string[] ConstantTags { get; set; }
        public const int DefaultStatsdPort = 8125;
        public const int DefaultStatsdMaxUDPPacketSize = 512;

        public const string DD_ENTITY_ID_ENV_VAR = "DD_ENTITY_ID";
        public const string DD_DOGSTATSD_PORT_ENV_VAR = "DD_DOGSTATSD_PORT";
        public const string DD_AGENT_HOST_ENV_VAR = "DD_AGENT_HOST";

        public StatsdConfig()
        {
            StatsdPort = 0;
            StatsdMaxUDPPacketSize = DefaultStatsdMaxUDPPacketSize;
        }
    }
}
