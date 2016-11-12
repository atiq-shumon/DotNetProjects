﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.INVMS.MODEL
{
    public class GroupDetails
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public string NameBeng { set; get; }
        public string Remarks { set; get; }
        public Majorgroup Majorgroup { set; get; }
        public StoreTypeSCM StoreType { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}