using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.AdderOrEditorForms.BrandAdderOrEditorForm
{
    public interface IBrandAdderOrEditorForm
    {
        BrandsTable BrandInfo { get; set; } 
        bool EditMode { get; set; }
    }
}
