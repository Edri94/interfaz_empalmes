﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEmplames.Models
{
    public class QueryParametro
    {
        public string Query { get; set; }
        public SqlParameter[] Parametros { get; set; }
    }
}
