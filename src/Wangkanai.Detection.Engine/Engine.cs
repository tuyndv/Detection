﻿// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

namespace Wangkanai.Detection
{
    public class Engine : IEngine
    {
        public string Name { get; set; }
        public string Maker { get; set; }
        public EngineType Type { get; set; }
        public Version Version { get; set; }
    }
}