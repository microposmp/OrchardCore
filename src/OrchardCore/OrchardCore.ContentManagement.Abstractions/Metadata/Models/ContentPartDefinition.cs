using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace OrchardCore.ContentManagement.Metadata.Models
{
    public class ContentPartDefinition : ContentDefinition
    {
        public string Feature { get; private set; }

        public ContentPartDefinition(string name)
        {
            Name = name;
            Fields = Enumerable.Empty<ContentPartFieldDefinition>();
            Settings = new JObject();
        }

        public ContentPartDefinition(string name, string feature)
        {
            Name = name;
            Feature = feature;
            Fields = Enumerable.Empty<ContentPartFieldDefinition>();
            Settings = new JObject();
        }

        public ContentPartDefinition(string name, IEnumerable<ContentPartFieldDefinition> fields, JObject settings)
        {
            Name = name;
            Feature = "Test2";
            Fields = fields.ToList();
            Settings = new JObject(settings);

            foreach (var field in Fields)
            {
                field.PartDefinition = this;
            }
        }

        public ContentPartDefinition(string name, string feature, IEnumerable<ContentPartFieldDefinition> fields, JObject settings)
        {
            Name = name;
            Feature = feature;
            Fields = fields.ToList();
            Settings = new JObject(settings);

            foreach (var field in Fields)
            {
                field.PartDefinition = this;
            }
        }

        public IEnumerable<ContentPartFieldDefinition> Fields { get; private set; }
    }
}
