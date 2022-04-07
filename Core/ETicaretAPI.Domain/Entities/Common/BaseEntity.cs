﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ETicaretAPI.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public  DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}