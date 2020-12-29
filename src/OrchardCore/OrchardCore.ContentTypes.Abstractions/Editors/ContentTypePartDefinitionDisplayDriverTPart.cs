using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchardCore.ContentTypes.Editors
{
    public abstract class ContentTypePartDefinitionDisplayDriver<TPart> : ContentTypePartDefinitionDisplayDriver
    {
        protected string GetSettingsEditorShapeType()
        {
            return typeof(TPart).Name + "Settings_Edit";
        }
    }
}
