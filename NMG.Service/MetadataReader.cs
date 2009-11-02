﻿using System.Collections.Generic;
using NMG.Core.Domain;

namespace NMG.Service
{
    public abstract class MetadataReader
    {
        protected readonly string connectionStr;

        protected MetadataReader(string connectionStr)
        {
            this.connectionStr = connectionStr;
        }

        public abstract ColumnDetails GetTableDetails(string selectedTableName);
        public abstract List<string> GetTables();
        public abstract List<string> GetSequences();
    }
}