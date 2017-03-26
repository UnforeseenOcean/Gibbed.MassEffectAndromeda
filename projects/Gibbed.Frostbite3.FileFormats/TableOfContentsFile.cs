﻿/* Copyright (c) 2017 Rick (rick 'at' gibbed 'dot' us)
 * 
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 * 
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 * 
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 * 
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace Gibbed.Frostbite3.FileFormats
{
    public class TableOfContentsFile
    {
        public static TableOfContentsFile Read(string path)
        {
            using (var input = File.OpenRead(path))
            {
                return LayerHelper.ReadObject(input, s => Read(s));
            }
        }

        public static TableOfContentsFile Read(Stream input)
        {
            return new DbObject.Serializer().Deserialize<TableOfContentsFile>(input);
        }

        [DbObject.Property("bundles")]
        public List<BundleInfo> Bundles { get; set; }

        [DbObject.Property("chunks")]
        public List<ChunkInfo> Chunks { get; set; }

        [DbObject.Property("cas")]
        public bool IsCas { get; set; }

        [DbObject.Property("name")]
        public string Name { get; set; }

        [DbObject.Property("alwaysEmitSuperbundle")]
        public bool AlwaysEmitSuperbundle { get; set; }

        public class BundleInfo
        {
            [DbObject.Property("id")]
            public string Id { get; set; }

            [DbObject.Property("offset")]
            public long Offset { get; set; }

            [DbObject.Property("size")]
            public long Size { get; set; }
        }

        public class ChunkInfo
        {
            [DbObject.Property("id")]
            public Guid Id { get; set; }

            [DbObject.Property("sha1")]
            public SHA1 SHA1 { get; set; }
        }
    }
}
