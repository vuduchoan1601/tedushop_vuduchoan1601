﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public class Auditable
    {
        public DateTime? CreateDate { set; get; }

        [MaxLength(256)]
        public string CreateBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        [MaxLength(256)]
        public string UpdateBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}