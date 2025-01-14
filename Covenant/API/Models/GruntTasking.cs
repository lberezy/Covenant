// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GruntTasking
    {
        /// <summary>
        /// Initializes a new instance of the GruntTasking class.
        /// </summary>
        public GruntTasking()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GruntTasking class.
        /// </summary>
        /// <param name="type">Possible values include: 'Assembly',
        /// 'SetOption', 'Kill', 'Connect', 'Disconnect', 'Jobs'</param>
        /// <param name="status">Possible values include: 'Uninitialized',
        /// 'Tasked', 'Progressed', 'Completed', 'Aborted'</param>
        public GruntTasking(string name, int gruntId, int gruntCommandId, int? id = default(int?), Grunt grunt = default(Grunt), int? gruntTaskId = default(int?), GruntTask gruntTask = default(GruntTask), GruntTaskingType? type = default(GruntTaskingType?), IList<string> parameters = default(IList<string>), GruntCommand gruntCommand = default(GruntCommand), GruntTaskingStatus? status = default(GruntTaskingStatus?), System.DateTime? taskingTime = default(System.DateTime?), System.DateTime? completionTime = default(System.DateTime?))
        {
            Id = id;
            Name = name;
            GruntId = gruntId;
            Grunt = grunt;
            GruntTaskId = gruntTaskId;
            GruntTask = gruntTask;
            Type = type;
            Parameters = parameters;
            GruntCommandId = gruntCommandId;
            GruntCommand = gruntCommand;
            Status = status;
            TaskingTime = taskingTime;
            CompletionTime = completionTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntId")]
        public int GruntId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grunt")]
        public Grunt Grunt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntTaskId")]
        public int? GruntTaskId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntTask")]
        public GruntTask GruntTask { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Assembly', 'SetOption',
        /// 'Kill', 'Connect', 'Disconnect', 'Jobs'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public GruntTaskingType? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<string> Parameters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntCommandId")]
        public int GruntCommandId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntCommand")]
        public GruntCommand GruntCommand { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Uninitialized', 'Tasked',
        /// 'Progressed', 'Completed', 'Aborted'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public GruntTaskingStatus? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskingTime")]
        public System.DateTime? TaskingTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completionTime")]
        public System.DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Grunt != null)
            {
                Grunt.Validate();
            }
            if (GruntTask != null)
            {
                GruntTask.Validate();
            }
            if (GruntCommand != null)
            {
                GruntCommand.Validate();
            }
        }
    }
}
