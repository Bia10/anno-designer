﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnoDesigner.Models
{
    public interface ICommons
    {
        event EventHandler SelectedLanguageChanged;

        IUpdateHelper UpdateHelper { get; }

        string SelectedLanguage { get; set; }
    }
}
