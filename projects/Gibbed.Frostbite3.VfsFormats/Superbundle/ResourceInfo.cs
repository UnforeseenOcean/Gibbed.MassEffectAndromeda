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

using Gibbed.Frostbite3.Common;
using DbObject = Gibbed.Frostbite3.Common.DbObject;

namespace Gibbed.Frostbite3.VfsFormats.Superbundle
{
    public class ResourceInfo : IDataInfo
    {
        [DbObject.Property("name")]
        public string Name { get; set; }

        [DbObject.Property("sha1")]
        public SHA1 SHA1 { get; set; }

        [DbObject.Property("size")]
        public long Size { get; set; }

        [DbObject.Property("originalSize")]
        public long OriginalSize { get; set; }

        [DbObject.Property("resType")]
        public int ResourceType { get; set; }

        [DbObject.Property("resMeta")]
        public byte[] ResourceMeta { get; set; }

        [DbObject.Property("resRid")]
        public long ResourceId { get; set; }

        [DbObject.Property("idata")]
        public byte[] InlineData { get; set; }

        public override string ToString()
        {
            return this.Name ?? base.ToString();
        }
    }
}
