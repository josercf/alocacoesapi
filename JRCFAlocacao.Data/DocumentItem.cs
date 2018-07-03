using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace JRCFAlocacao.Data
{
    public abstract class DocumentItem
    {
        public ObjectId Id { get; set; }
    }
}
