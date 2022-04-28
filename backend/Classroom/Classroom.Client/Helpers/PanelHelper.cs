using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classroom.Client.HelpEntities;

namespace Classroom.Client.Helpers
{
    public class PanelHelper
    {
        public static void OpenPanel(List<PanelDto> _panelDto, string namePanel)
        {
            _panelDto.Where(p => p.Name != namePanel).All(p =>
            {
                p.PanelEntity.Visible = false;
                return true;
            });
            _panelDto.Where(p => p.Name == namePanel).All(p =>
            {
                p.PanelEntity.Visible = true;
                return true;
            });
        }
        
    }
}
