// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

namespace Wangkanai.Detection
{
    public class Platform
    {
        public string Name { get; set; }        
        public Version Version { get; set; }
        public byte Bits { get; set; }
        //waiting for beta 3 published nuget
        //public PlatformType Type { get; set; }
    }
}