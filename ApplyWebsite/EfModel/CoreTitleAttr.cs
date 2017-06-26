﻿using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CoreTitleAttr
    {
        public int TitleId { get; set; }
        public int AttrId { get; set; }

        public virtual Attr Attr { get; set; }
        public virtual CoreTitle Title { get; set; }
    }
}
