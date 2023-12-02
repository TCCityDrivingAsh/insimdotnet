namespace InSimDotNet.Packets
{
    /// <summary>
    /// Switches for <see cref="IS_SMALL"/> SMALL_LCS
    /// </summary>
    public static class LocalCarLights
    {
        /// <summary>
        /// Bit 0
        /// </summary>
        public const int LCL_SET_SIGNALS = 1;  // bit 0

        /// <summary>
        ///  bit 2
        /// </summary>
        public const int LCL_SET_LIGHTS = 1 << 2; // bit 2

        /// <summary>
        /// Bit 4
        /// </summary>
        public const int LCL_SET_FOG_REAR = 1 << 4; // bit 4

        /// <summary>
        /// Bit 5
        /// </summary>
        public const int LCL_SET_FOG_FRONT = 1 << 5; // bit 5

        /// <summary>
        /// Bit 6
        /// </summary>
        public const int LCL_SET_EXTRA = 1 << 6; // bit 6

        /// <summary>
        /// Turn signals off
        /// </summary>
        public const int LCL_SIGNALS_OFF = LCL_SET_SIGNALS;

        /// <summary>
        /// Turn signal left
        /// </summary>
        public const int LCL_SIGNALS_LEFT = (1 << 16) + LCL_SET_SIGNALS;

        /// <summary>
        /// Turn signal right
        /// </summary>
        public const int LCL_SIGNALS_RIGHT = (2 << 16) + LCL_SET_SIGNALS;

        /// <summary>
        /// Turn signal hazard
        /// </summary>
        public const int LCL_SIGNALS_HAZARD = (3 << 16) + LCL_SET_SIGNALS;

        /// <summary>
        /// Turn headlights off
        /// </summary>
        public const int LCL_HEADLIGHTS_OFF = LCL_SET_LIGHTS;

        /// <summary>
        /// Turn sidelights on
        /// </summary>
        public const int LCL_HEADLIGHTS_SIDE = (1 << 18) + LCL_SET_LIGHTS;

        /// <summary>
        /// Turn dipped beam on
        /// </summary>
        public const int LCL_HEADLIGHTS_DIPPED = (2 << 18) + LCL_SET_LIGHTS;

        /// <summary>
        /// Turn full beam on
        /// </summary>
        public const int LCL_HEADLIGHTS_FULL = (3 << 18) + LCL_SET_LIGHTS;

        /// <summary>
        /// Turn rear fog light off
        /// </summary>
        public const int LCL_FOG_REAR_OFF = LCL_SET_FOG_REAR;

        /// <summary>
        /// Turn rear fog light on
        /// </summary>
        public const int LCL_FOG_REAR_ON = (1 << 20) + LCL_SET_FOG_REAR;

        /// <summary>
        /// Turn front fog light off
        /// </summary>
        public const int LCL_FOG_FRONT_OFF = LCL_SET_FOG_FRONT;

        /// <summary>
        /// Turn front fog light on
        /// </summary>
        public const int LCL_FOG_FRONT_ON = (1 << 21) + LCL_SET_FOG_FRONT;

        /// <summary>
        /// Turn extra light off
        /// </summary>
        public const int LCL_EXTRA_OFF = LCL_SET_EXTRA;

        /// <summary>
        /// Turn extra light off
        /// </summary>
        public const int LCL_EXTRA_ON = (1 << 22) + LCL_SET_EXTRA;
    }
}