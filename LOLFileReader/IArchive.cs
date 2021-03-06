﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOLFileReader
{
    public interface IArchive
    {
        /// <summary>
        /// File file entries in the archive that ends with endsWith.
        /// </summary>
        /// <returns></returns>
        List<IFileEntry> SearchFileEntries(string[] endsWiths);
    }
}
